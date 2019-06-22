using System;
using System.Windows.Forms;

namespace Arduino_simple_16x16_Dot_Matrix_code_generator_DEMO
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HexGenerator());
        }
    }
}
