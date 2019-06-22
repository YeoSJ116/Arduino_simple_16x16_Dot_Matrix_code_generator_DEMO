namespace Arduino_simple_16x16_Dot_Matrix_code_generator_DEMO
{
    partial class HexGenerator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Image_Group = new System.Windows.Forms.GroupBox();
            this.Zoom_View = new System.Windows.Forms.Panel();
            this.Original_View = new System.Windows.Forms.Panel();
            this.Original_TEXT = new System.Windows.Forms.Label();
            this.SaveImage = new System.Windows.Forms.Button();
            this.reverse = new System.Windows.Forms.Button();
            this.Boold = new System.Windows.Forms.Button();
            this.Cod_Out = new System.Windows.Forms.TextBox();
            this.Input_Text = new System.Windows.Forms.TextBox();
            this.Print = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.SettingsGroup = new System.Windows.Forms.GroupBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.Button();
            this.Right_ = new System.Windows.Forms.Button();
            this.Left_ = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Font_Down = new System.Windows.Forms.Button();
            this.Font_up = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.InputLabel = new System.Windows.Forms.Label();
            this.PrintLabel = new System.Windows.Forms.Label();
            this.OptionGroup = new System.Windows.Forms.GroupBox();
            this.AutoIMGsave = new System.Windows.Forms.CheckBox();
            this.Speed = new System.Windows.Forms.NumericUpDown();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.ModuleLabel = new System.Windows.Forms.Label();
            this.Module = new System.Windows.Forms.NumericUpDown();
            this.AutoCodeCopy = new System.Windows.Forms.CheckBox();
            this.DistinctGroup = new System.Windows.Forms.GroupBox();
            this.DistinctListBox = new System.Windows.Forms.ListBox();
            this.Info = new System.Windows.Forms.Button();
            this.LogTbox = new System.Windows.Forms.TextBox();
            this.LogLable = new System.Windows.Forms.Label();
            this.Image_Group.SuspendLayout();
            this.Original_View.SuspendLayout();
            this.SettingsGroup.SuspendLayout();
            this.OptionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module)).BeginInit();
            this.DistinctGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Image_Group
            // 
            this.Image_Group.Controls.Add(this.Zoom_View);
            this.Image_Group.Controls.Add(this.Original_View);
            this.Image_Group.Controls.Add(this.SaveImage);
            this.Image_Group.Controls.Add(this.reverse);
            this.Image_Group.Controls.Add(this.Boold);
            this.Image_Group.Location = new System.Drawing.Point(12, 12);
            this.Image_Group.Name = "Image_Group";
            this.Image_Group.Size = new System.Drawing.Size(205, 100);
            this.Image_Group.TabIndex = 1;
            this.Image_Group.TabStop = false;
            this.Image_Group.Text = "Kernel";
            // 
            // Zoom_View
            // 
            this.Zoom_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Zoom_View.Location = new System.Drawing.Point(85, 13);
            this.Zoom_View.Name = "Zoom_View";
            this.Zoom_View.Size = new System.Drawing.Size(80, 80);
            this.Zoom_View.TabIndex = 2;
            // 
            // Original_View
            // 
            this.Original_View.BackColor = System.Drawing.Color.White;
            this.Original_View.Controls.Add(this.Original_TEXT);
            this.Original_View.Location = new System.Drawing.Point(33, 45);
            this.Original_View.Name = "Original_View";
            this.Original_View.Size = new System.Drawing.Size(16, 16);
            this.Original_View.TabIndex = 0;
            // 
            // Original_TEXT
            // 
            this.Original_TEXT.AutoSize = true;
            this.Original_TEXT.BackColor = System.Drawing.Color.Transparent;
            this.Original_TEXT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Original_TEXT.ForeColor = System.Drawing.Color.Black;
            this.Original_TEXT.Location = new System.Drawing.Point(-3, 0);
            this.Original_TEXT.Name = "Original_TEXT";
            this.Original_TEXT.Size = new System.Drawing.Size(24, 16);
            this.Original_TEXT.TabIndex = 0;
            this.Original_TEXT.Text = "한";
            this.Original_TEXT.FontChanged += new System.EventHandler(this.Original_TEXT_FontChanged);
            this.Original_TEXT.LocationChanged += new System.EventHandler(this.Original_TEXT_LocationChanged);
            this.Original_TEXT.TextChanged += new System.EventHandler(this.Original_TEXT_TextChanged);
            // 
            // SaveImage
            // 
            this.SaveImage.Location = new System.Drawing.Point(171, 13);
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(25, 80);
            this.SaveImage.TabIndex = 4;
            this.SaveImage.Text = "저  장";
            this.SaveImage.UseVisualStyleBackColor = true;
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // reverse
            // 
            this.reverse.Location = new System.Drawing.Point(8, 22);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(71, 19);
            this.reverse.TabIndex = 6;
            this.reverse.Text = "반전";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.reverse_Click);
            // 
            // Boold
            // 
            this.Boold.Location = new System.Drawing.Point(8, 65);
            this.Boold.Name = "Boold";
            this.Boold.Size = new System.Drawing.Size(71, 19);
            this.Boold.TabIndex = 6;
            this.Boold.Text = "굵게 하기";
            this.Boold.UseVisualStyleBackColor = true;
            this.Boold.Click += new System.EventHandler(this.Boold_Click);
            // 
            // Cod_Out
            // 
            this.Cod_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cod_Out.Font = new System.Drawing.Font("굴림체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cod_Out.Location = new System.Drawing.Point(61, 153);
            this.Cod_Out.Multiline = true;
            this.Cod_Out.Name = "Cod_Out";
            this.Cod_Out.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Cod_Out.Size = new System.Drawing.Size(669, 167);
            this.Cod_Out.TabIndex = 2;
            // 
            // Input_Text
            // 
            this.Input_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input_Text.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Input_Text.Location = new System.Drawing.Point(61, 118);
            this.Input_Text.Name = "Input_Text";
            this.Input_Text.Size = new System.Drawing.Size(669, 29);
            this.Input_Text.TabIndex = 3;
            this.Input_Text.TextChanged += new System.EventHandler(this.Input_Text_TextChanged);
            this.Input_Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_Text_KeyDown);
            // 
            // Print
            // 
            this.Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Print.Location = new System.Drawing.Point(736, 118);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(46, 29);
            this.Print.TabIndex = 4;
            this.Print.Text = "출력";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(113, 14);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(23, 80);
            this.RESET.TabIndex = 5;
            this.RESET.Text = "초기화";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // SettingsGroup
            // 
            this.SettingsGroup.Controls.Add(this.PositionLabel);
            this.SettingsGroup.Controls.Add(this.SizeLabel);
            this.SettingsGroup.Controls.Add(this.Down);
            this.SettingsGroup.Controls.Add(this.Right_);
            this.SettingsGroup.Controls.Add(this.Left_);
            this.SettingsGroup.Controls.Add(this.Up);
            this.SettingsGroup.Controls.Add(this.Font_Down);
            this.SettingsGroup.Controls.Add(this.Font_up);
            this.SettingsGroup.Controls.Add(this.RESET);
            this.SettingsGroup.Location = new System.Drawing.Point(223, 12);
            this.SettingsGroup.Name = "SettingsGroup";
            this.SettingsGroup.Size = new System.Drawing.Size(142, 100);
            this.SettingsGroup.TabIndex = 3;
            this.SettingsGroup.TabStop = false;
            this.SettingsGroup.Text = "Settings";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(6, 61);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(29, 12);
            this.PositionLabel.TabIndex = 8;
            this.PositionLabel.Text = "위치";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(6, 27);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(29, 12);
            this.SizeLabel.TabIndex = 8;
            this.SizeLabel.Text = "크기";
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(64, 71);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(19, 19);
            this.Down.TabIndex = 7;
            this.Down.Text = "▼";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Right_
            // 
            this.Right_.Location = new System.Drawing.Point(86, 58);
            this.Right_.Name = "Right_";
            this.Right_.Size = new System.Drawing.Size(19, 19);
            this.Right_.TabIndex = 6;
            this.Right_.Text = "▶";
            this.Right_.UseVisualStyleBackColor = true;
            this.Right_.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left_
            // 
            this.Left_.Location = new System.Drawing.Point(42, 59);
            this.Left_.Name = "Left_";
            this.Left_.Size = new System.Drawing.Size(19, 19);
            this.Left_.TabIndex = 6;
            this.Left_.Text = "◀";
            this.Left_.UseVisualStyleBackColor = true;
            this.Left_.Click += new System.EventHandler(this.Left_Click);
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(64, 48);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(19, 19);
            this.Up.TabIndex = 6;
            this.Up.Text = "▲";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Font_Down
            // 
            this.Font_Down.Location = new System.Drawing.Point(78, 23);
            this.Font_Down.Name = "Font_Down";
            this.Font_Down.Size = new System.Drawing.Size(29, 19);
            this.Font_Down.TabIndex = 7;
            this.Font_Down.Text = "▼";
            this.Font_Down.UseVisualStyleBackColor = true;
            this.Font_Down.Click += new System.EventHandler(this.Font_Down_Click);
            // 
            // Font_up
            // 
            this.Font_up.Location = new System.Drawing.Point(43, 23);
            this.Font_up.Name = "Font_up";
            this.Font_up.Size = new System.Drawing.Size(29, 19);
            this.Font_up.TabIndex = 6;
            this.Font_up.Text = "▲";
            this.Font_up.UseVisualStyleBackColor = true;
            this.Font_up.Click += new System.EventHandler(this.Font_up_Click);
            // 
            // Copy
            // 
            this.Copy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Copy.Location = new System.Drawing.Point(736, 153);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(46, 167);
            this.Copy.TabIndex = 5;
            this.Copy.Text = "복사";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputLabel.Location = new System.Drawing.Point(8, 123);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(47, 19);
            this.InputLabel.TabIndex = 6;
            this.InputLabel.Text = "입력";
            // 
            // PrintLabel
            // 
            this.PrintLabel.AutoSize = true;
            this.PrintLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PrintLabel.Location = new System.Drawing.Point(8, 155);
            this.PrintLabel.Name = "PrintLabel";
            this.PrintLabel.Size = new System.Drawing.Size(47, 19);
            this.PrintLabel.TabIndex = 7;
            this.PrintLabel.Text = "출력";
            // 
            // OptionGroup
            // 
            this.OptionGroup.Controls.Add(this.AutoIMGsave);
            this.OptionGroup.Controls.Add(this.Speed);
            this.OptionGroup.Controls.Add(this.SpeedLabel);
            this.OptionGroup.Controls.Add(this.ModuleLabel);
            this.OptionGroup.Controls.Add(this.Module);
            this.OptionGroup.Controls.Add(this.AutoCodeCopy);
            this.OptionGroup.Location = new System.Drawing.Point(371, 12);
            this.OptionGroup.Name = "OptionGroup";
            this.OptionGroup.Size = new System.Drawing.Size(139, 100);
            this.OptionGroup.TabIndex = 9;
            this.OptionGroup.TabStop = false;
            this.OptionGroup.Text = "Option";
            // 
            // AutoIMGsave
            // 
            this.AutoIMGsave.AutoSize = true;
            this.AutoIMGsave.Location = new System.Drawing.Point(24, 34);
            this.AutoIMGsave.Name = "AutoIMGsave";
            this.AutoIMGsave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AutoIMGsave.Size = new System.Drawing.Size(105, 16);
            this.AutoIMGsave.TabIndex = 8;
            this.AutoIMGsave.Text = "자동 bmp 저장";
            this.AutoIMGsave.UseVisualStyleBackColor = true;
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(13, 50);
            this.Speed.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.Speed.Minimum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(57, 21);
            this.Speed.TabIndex = 7;
            this.Speed.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(76, 56);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(53, 12);
            this.SpeedLabel.TabIndex = 6;
            this.SpeedLabel.Text = "속      도";
            // 
            // ModuleLabel
            // 
            this.ModuleLabel.AutoSize = true;
            this.ModuleLabel.Location = new System.Drawing.Point(76, 78);
            this.ModuleLabel.Name = "ModuleLabel";
            this.ModuleLabel.Size = new System.Drawing.Size(53, 12);
            this.ModuleLabel.TabIndex = 4;
            this.ModuleLabel.Text = "모듈갯수";
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(13, 74);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(57, 21);
            this.Module.TabIndex = 3;
            this.Module.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // AutoCodeCopy
            // 
            this.AutoCodeCopy.AutoSize = true;
            this.AutoCodeCopy.Location = new System.Drawing.Point(25, 17);
            this.AutoCodeCopy.Name = "AutoCodeCopy";
            this.AutoCodeCopy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AutoCodeCopy.Size = new System.Drawing.Size(104, 16);
            this.AutoCodeCopy.TabIndex = 0;
            this.AutoCodeCopy.Text = "자동 코드 복사";
            this.AutoCodeCopy.UseVisualStyleBackColor = true;
            // 
            // DistinctGroup
            // 
            this.DistinctGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DistinctGroup.Controls.Add(this.DistinctListBox);
            this.DistinctGroup.Location = new System.Drawing.Point(659, 12);
            this.DistinctGroup.Name = "DistinctGroup";
            this.DistinctGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DistinctGroup.Size = new System.Drawing.Size(123, 100);
            this.DistinctGroup.TabIndex = 10;
            this.DistinctGroup.TabStop = false;
            this.DistinctGroup.Text = "Distinct value";
            // 
            // DistinctListBox
            // 
            this.DistinctListBox.BackColor = System.Drawing.SystemColors.Control;
            this.DistinctListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DistinctListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DistinctListBox.FormattingEnabled = true;
            this.DistinctListBox.ItemHeight = 12;
            this.DistinctListBox.Location = new System.Drawing.Point(3, 17);
            this.DistinctListBox.Name = "DistinctListBox";
            this.DistinctListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DistinctListBox.Size = new System.Drawing.Size(117, 80);
            this.DistinctListBox.TabIndex = 11;
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Info.Location = new System.Drawing.Point(736, 326);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(46, 107);
            this.Info.TabIndex = 1;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // LogTbox
            // 
            this.LogTbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.LogTbox.ForeColor = System.Drawing.Color.Lime;
            this.LogTbox.Location = new System.Drawing.Point(61, 326);
            this.LogTbox.Multiline = true;
            this.LogTbox.Name = "LogTbox";
            this.LogTbox.ReadOnly = true;
            this.LogTbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTbox.Size = new System.Drawing.Size(669, 107);
            this.LogTbox.TabIndex = 11;
            this.LogTbox.TextChanged += new System.EventHandler(this.LogTbox_TextChanged);
            // 
            // LogLable
            // 
            this.LogLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogLable.AutoSize = true;
            this.LogLable.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LogLable.Location = new System.Drawing.Point(8, 326);
            this.LogLable.Name = "LogLable";
            this.LogLable.Size = new System.Drawing.Size(47, 19);
            this.LogLable.TabIndex = 12;
            this.LogLable.Text = "로그";
            // 
            // HexGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 445);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.LogLable);
            this.Controls.Add(this.LogTbox);
            this.Controls.Add(this.DistinctGroup);
            this.Controls.Add(this.OptionGroup);
            this.Controls.Add(this.PrintLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.SettingsGroup);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Input_Text);
            this.Controls.Add(this.Cod_Out);
            this.Controls.Add(this.Image_Group);
            this.MinimumSize = new System.Drawing.Size(667, 484);
            this.Name = "HexGenerator";
            this.Text = "YeoSJ116\'s Arduino simple 16x16 Dot Matrix code generator DEMO";
            this.Image_Group.ResumeLayout(false);
            this.Original_View.ResumeLayout(false);
            this.Original_View.PerformLayout();
            this.SettingsGroup.ResumeLayout(false);
            this.SettingsGroup.PerformLayout();
            this.OptionGroup.ResumeLayout(false);
            this.OptionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module)).EndInit();
            this.DistinctGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Image_Group;
        private System.Windows.Forms.Panel Zoom_View;
        private System.Windows.Forms.Panel Original_View;
        private System.Windows.Forms.Label Original_TEXT;
        private System.Windows.Forms.TextBox Cod_Out;
        private System.Windows.Forms.TextBox Input_Text;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.GroupBox SettingsGroup;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Right_;
        private System.Windows.Forms.Button Left_;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Font_Down;
        private System.Windows.Forms.Button Font_up;
        private System.Windows.Forms.Button Boold;
        private System.Windows.Forms.Button reverse;
        private System.Windows.Forms.Button SaveImage;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label PrintLabel;
        private System.Windows.Forms.GroupBox OptionGroup;
        private System.Windows.Forms.CheckBox AutoCodeCopy;
        private System.Windows.Forms.GroupBox DistinctGroup;
        private System.Windows.Forms.ListBox DistinctListBox;
        private System.Windows.Forms.NumericUpDown Module;
        private System.Windows.Forms.Label ModuleLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.NumericUpDown Speed;
        private System.Windows.Forms.TextBox LogTbox;
        private System.Windows.Forms.Label LogLable;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.CheckBox AutoIMGsave;
    }
}

