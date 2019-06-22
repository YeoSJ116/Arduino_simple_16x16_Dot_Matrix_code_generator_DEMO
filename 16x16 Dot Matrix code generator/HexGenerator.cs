using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.IO.Directory;

/* If you can't understand korean language?
 * Tell me know it on Github Issues page!
 * I will help you ;)
 * Github Issues URL: https://github.com/YeoSJ116/Arduino_simple_16x16_Dot_Matrix_code_generator_DEMO
 * 
 * 20119.06.22 Release open-source 1.0.0 BY YeoSJ116
 */
namespace Arduino_simple_16x16_Dot_Matrix_code_generator_DEMO
{
    public partial class HexGenerator : Form
    {
        //프로그램에 대한 정보를 표시하기 위해 재작자의 깃 허브로 이동 합니다.
        private void Info_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://github.com/YeoSJ116/Arduino_simple_16x16_Dot_Matrix_code_generator_DEMO");

        string enter = "\r\n";
        string AutoSaveFileName = ""; //런타임 중에(실행 중에) 이 변수에 자동 저장시 저장할 파일 이름을 지정 합니다.
        int countSave = 1; //비트맵 저장시 자동으로 뒤에 숫자가 붙도록 하기위한 변수 입니다.

        public HexGenerator()
        {
            InitializeComponent();
            Zoomimg();
            OriginalFresh();
            LogConsole("배포판 버전 1.0.0");
        }

        // 비트맵 이미지 형식으로 저장하는 함수입니다.
        private void SaveImage_Click(object sender, EventArgs e) => BMPsave();
        void OriginalFresh() => Original_TEXT.Text = Input_Text.Text;
        // 안티에일리어싱 기능을 사용하지 않고 이미지를 늘리기 위한 함수 입니다.
        void Zoomimg()
        {
            Bitmap Obmp = new Bitmap(16, 16); //Original
            Original_View.DrawToBitmap(Obmp, new Rectangle(0, 0, 16, 16));

            Bitmap Rbmp = new Bitmap(80, 80); //Resize
            for (int x = 0; x < 16; x++) //Resize  - No Anti-Aliasing
                for (int y = 0; y < 16; y++)
                {
                    Color value = Obmp.GetPixel(x, y);
                    int
                        _x = x * 5,
                        _y = y * 5;
                    for (int X = 0; X < 5; X++)
                        for (int Y = 0; Y < 5; Y++)
                            Rbmp.SetPixel(_x + X, _y + Y, value);
                }
            Zoom_View.BackgroundImage = Rbmp;
        }
        //다른 프로그램에서 사용될 경우 비트맵으로 저장하기 위한 기능 입니다.
        void BMPsave()
        {
            Bitmap Obmp = new Bitmap(16, 16);
            Original_View.DrawToBitmap(Obmp, new Rectangle(0, 0, 16, 16));
            Obmp.Save("Save" + countSave + ".bmp");
            countSave++;
        }
        void BMPsave(int Arry_value, char Text_value)
        {
            Bitmap Obmp = new Bitmap(16, 16);
            Original_View.DrawToBitmap(Obmp, new Rectangle(0, 0, 16, 16));
            char[] replace = new char[] { '\\', '/', ':', '*', '?', '"', '<', '>', '|' };
            foreach (char i in replace)
                if (Text_value == i) Text_value = '_';

            Obmp.Save(AutoSaveFileName + "\\" + Arry_value + " " + Text_value + ".bmp");
        }
        //자동 저장시의 파일 위치를 지정하고 로그로 남깁니다.
        void AutoSaveInfo()
        {
            string Title = Input_Text.Text;
            char[] replace = new char[] { '\\', '/', ':', '*', '?', '"', '<', '>', '|' };
            foreach (char i in replace)
                Title = Title.Replace(i, '_');
            AutoSaveFileName = DateTime.Now.ToString("yyyyMMdd_hhmmss ") + Title;

            try
            {
                CreateDirectory(AutoSaveFileName);
            }
            catch (Exception e)
            {
                LogConsole("[자동 저장 오류] 충분한 접근 권한이 있는지 확인해 주십시오");
                LogConsole("[자동 저장 오류] 세부 정보: " + e.Message);
            }

            //LogConsole("[안내] 입력 문자에 \\, /, :, *, ?,\", <, >, | 와 같은 특수문자는 자동으로 _ 로 바꾸어 파일명을 지정합니다.");
            LogConsole("[자동 저장] 파일명: " + AutoSaveFileName);
            LogConsole("[자동 저장] 경로: " + string.Format(Environment.CurrentDirectory + "\\" + AutoSaveFileName).Replace(@"\\",@"\"));
        }
        
        //출력 버튼 클릭시
        private void Print_Click(object sender, EventArgs e)
        {
            OriginalFresh();
            Zoomimg();
            Printout();
        }
        // Enter 키를 누르면 자동으로 코드 출력 버튼을 누른 것과 같은 기능을 제공하기 위한 함수 입니다.
        private void Input_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Printout();
        }
        /// <summary>
        /// 배열 중복 제거 함수: 중복되는 문자 데이터는 다시 만들 필요가 없으므로 생략하기 위한 기능 입니다.
        /// </summary>
        public string GetDistinctValues<T>(T[] array)
        {
            DistinctListBox.Items.Clear();
            List<T> tmp = new List<T>();

            string Index = null;
            T[] Index_target = array;
            int count = array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (tmp.Contains(array[i]))
                    continue;
                DistinctListBox.Items.Add(array[i]);
                tmp.Add(array[i]);
            }
            for (int i = 0; i < count; i++)
            {
                Index += DistinctListBox.FindString(Index_target[i] + "");
                if (i != count - 1)
                    Index += ", ";
            }
            return Index;
        }
        /// <summary>
        /// 입력된 문자를 비트맵을 사용하여 아두이노 전자광판에 알맞게 16진수로 바꾸어 주는 함수 입니다.
        /// </summary>
        /// <param name="input">16진수 코드로 바꾸고 싶은 문자를 입력 합니다.</param>
        /// <returns></returns>
        string Bmp2Hex(string input)
        {
            Original_TEXT.Text = input;
            string codeResult = null;
            Bitmap Obmp = new Bitmap(16, 16);
            Original_View.DrawToBitmap(Obmp, new Rectangle(0, 0, 16, 16));

            Byte[] PatternL = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            Byte[] PatternR = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            for (int H = 0; H < 16; H++) //0부터 15까지 총 16번 반복 합니다. 배열은 0에서 부터 시작 한다는 점 잊지 마세요!
            {
                for (int L = 0; L < 8; L++)
                {
                    double multiple = 0;
                    if (Obmp.GetPixel(7 - L, H).R >= 127)
                        multiple += Math.Pow(2, L);
                    PatternL[H] += (byte)multiple;
                }
                for (int R = 8; R < 16; R++)
                {
                    double multiple = 0;
                    if (Obmp.GetPixel(23 - R, H).R >= 127)
                        multiple += Math.Pow(2, R - 8);
                    PatternR[H] += (byte)multiple;
                }

                codeResult = "    0x" + BitConverter.ToString(PatternL).Replace("-", ",0x");
                codeResult += ",\r\n";
                codeResult += "    0x" + BitConverter.ToString(PatternR).Replace("-", ",0x");
                codeResult += ", //" + input + enter;
            }
            return codeResult;
        }
        /// <summary>
        /// 완전한 아두이노 코드를 출력하는 함수입니다.
        /// </summary>
        public void Printout()
        {
            LogConsole("[알림]코드 생성중...");
            if (AutoIMGsave.Checked) AutoSaveInfo();
            string index = GetDistinctValues<char>(Input_Text.Text.ToCharArray());
            Cod_Out.Text = null;

            //Read Me out
            Cod_Out.Text += "// 입력 문자: " + Input_Text.Text + "\r\n";
            Cod_Out.Text += "// 출력 문자: " + DistinctListBox.Items.Count + "개\r\n";
            Cod_Out.Text += "// 생성 날짜: " + DateTime.Now.ToString("yyyy년 MM월 dd일") + "\r\n\r\n";

            //Head print
            Cod_Out.Text += Properties.Resources.Header + enter;
            Cod_Out.Text += "#define Display_Num_Word " + Module.Value + " // Count of module" + enter;
            Cod_Out.Text += "#define Num_Of_Word " + (DistinctListBox.Items.Count) + " // Count of char Word" + enter;
            Cod_Out.Text += "#define runs " + Speed.Value + " // Fast 900 ~ default 1000 ~ Slow 1100\r\n";

            //Hex print (Data)
            Cod_Out.Text += "unsigned char serial_index = " + (Input_Text.TextLength) + ";\r\n";
            Cod_Out.Text += "unsigned char DP_Buffer[" + (Input_Text.TextLength) + "] = {" + index + "};\r\n\r\n";
            
            Cod_Out.Text += "PROGMEM const unsigned char Word[Num_Of_Word][32] = {\r\n";
            for (int i = 0; i < DistinctListBox.Items.Count; i++)
            {
                Cod_Out.Text += Bmp2Hex(DistinctListBox.Items[i].ToString());
                if (AutoIMGsave.Checked) BMPsave(i, (char)DistinctListBox.Items[i]);
                if (i != DistinctListBox.Items.Count - 1)
                    Cod_Out.Text += enter;
                else continue;
            }
            Cod_Out.Text += "};\r\n";

            //Foot print
            Cod_Out.Text += Properties.Resources.Footer;

            LogConsole("[알림]코드가 출력되었습니다.");
            if (AutoCodeCopy.Checked) ClipCopy();
        }
        //클립보드에 코드를 복사합니다. 만약 비어 있으면 코드를 복사하지 않습니다.
        void ClipCopy()
        {
            if (Cod_Out.Text != "")
            {
                Clipboard.SetText(Cod_Out.Text);
                LogConsole("[알림] 클립보드에 코드가 복사 되었습니다.");
            }
            else
            {
                LogConsole("[오류] 코드가 비어있으므로 복사하지 않았습니다.");
                MessageBox.Show("코드가 비어있으므로 복사하지 않았습니다.", "코드가 복사되지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //클립보드로 코드를 복사 하는 버튼
        private void Copy_Click(object sender, EventArgs e) => ClipCopy();

        //글꼴과 관련된 설정 값 입니다.
        string FontShape = "굴림";
        float FontSize = 12;
        FontStyle FontST = FontStyle.Regular;
        bool Bstate = false;
        int Xx = -3,
            Yy = 0;
        //글자와 관련된 모든 설정을 초기 값으로 바꿉니다.
        private void RESET_Click(object sender, EventArgs e)
        {
            FontShape = "굴림";
            FontSize = 12;
            FontST = FontStyle.Regular;
            Bstate = false;
            Xx = -3;
            Yy = 0;

            Original_TEXT.Font = new Font(FontShape, FontSize, FontST);
            Original_TEXT.Location = new Point(Xx, Yy);
        }
        // 색상을 반전 시킵니다. 0이 ON이고 1이 OFF로 표현되는 전광판을 위해 고안된 기능 입니다.
        private void reverse_Click(object sender, EventArgs e)
        {
            Color a = Original_TEXT.ForeColor;
            Original_TEXT.ForeColor = Original_View.BackColor;
            Original_View.BackColor = a;
            OriginalFresh();
            Zoomimg();
        }
        //글자를 굵게설정 할 수 있습니다.
        private void Boold_Click(object sender, EventArgs e)
        {
            if (Bstate)
            {
                FontST = FontStyle.Regular;
                Bstate = false;
                Boold.Text = "굵게 하기";
            }
            else
            {
                FontST = FontStyle.Bold;
                Bstate = true;
                Boold.Text = "얇게 하기";
            }
            Original_TEXT.Font = new Font(FontShape, FontSize, FontST);
        }
        //글자 크기를 늘립니다.
        private void Font_up_Click(object sender, EventArgs e)
        {
            FontSize = ++FontSize;
            Original_TEXT.Font = new Font(FontShape, FontSize, FontST);
        }
        //글자 크기를 줄입니다.
        private void Font_Down_Click(object sender, EventArgs e)
        {
            FontSize = --FontSize;
            Original_TEXT.Font = new Font(FontShape, FontSize, FontST);
        }
        //오른쪽으로 글자를 조정 합니다.
        private void Left_Click(object sender, EventArgs e)
        {
            Xx = --Xx;
            Original_TEXT.Location = new Point(Xx, Yy);
        }
        //왼쪽으로 글자를 조정 합니다.
        private void Right_Click(object sender, EventArgs e)
        {
            Xx = ++Xx;
            Original_TEXT.Location = new Point(Xx, Yy);
        }
        //위로 글자를 조정 합니다.
        private void Up_Click(object sender, EventArgs e)
        {
            Yy = --Yy;
            Original_TEXT.Location = new Point(Xx, Yy);
        }
        //아래로 글자를 조정 합니다.
        private void Down_Click(object sender, EventArgs e)
        {
            Yy = ++Yy;
            Original_TEXT.Location = new Point(Xx, Yy);
        }
        private void Original_TEXT_LocationChanged(object sender, EventArgs e)
        {
            Zoomimg();
        }

        //커널에 보이는 글자 이미지가 실시간으로 반영 되기 위한 기능들 입니다.
        private void Input_Text_TextChanged(object sender, EventArgs e)
        {
            OriginalFresh();
            Zoomimg();
        }
        private void Original_TEXT_TextChanged(object sender, EventArgs e) => Zoomimg();
        private void Original_TEXT_FontChanged(object sender, EventArgs e) => Zoomimg();

        //로그 기록과 관련된 함수 입니다.
        void LogConsole(string log) => LogTbox.Text += Time() + log + enter;
        string Time() => string.Format("[" + DateTime.Now.ToString("yyyy_MM_dd - hh:mm.ss") + "] ");
        //항상 최근에 표시되는 로그가 보이도록 스크롤을 최 하단으로 이동 시킵니다.
        private void LogTbox_TextChanged(object sender, EventArgs e)
        {
            LogTbox.SelectionStart = LogTbox.Text.Length;
            LogTbox.ScrollToCaret();
        }
    }
}