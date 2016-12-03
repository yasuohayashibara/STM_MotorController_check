namespace STM_MotorController_check
{
    partial class FormMotorControllerCheck
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonServoOn = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBoxServoOn = new System.Windows.Forms.TextBox();
            this.buttonGain = new System.Windows.Forms.Button();
            this.buttonPWMLimit = new System.Windows.Forms.Button();
            this.textBoxGain = new System.Windows.Forms.TextBox();
            this.textBoxPWMLimit = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonMargin = new System.Windows.Forms.Button();
            this.textBoxMargin = new System.Windows.Forms.TextBox();
            this.buttonInitialPos = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTracking = new System.Windows.Forms.TabPage();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxCommPort = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.checkBoxID1 = new System.Windows.Forms.CheckBox();
            this.checkBoxID2 = new System.Windows.Forms.CheckBox();
            this.checkBoxID3 = new System.Windows.Forms.CheckBox();
            this.checkBoxID4 = new System.Windows.Forms.CheckBox();
            this.checkBoxID5 = new System.Windows.Forms.CheckBox();
            this.checkBoxID6 = new System.Windows.Forms.CheckBox();
            this.checkBoxID12 = new System.Windows.Forms.CheckBox();
            this.checkBoxID11 = new System.Windows.Forms.CheckBox();
            this.checkBoxID10 = new System.Windows.Forms.CheckBox();
            this.checkBoxID9 = new System.Windows.Forms.CheckBox();
            this.checkBoxID8 = new System.Windows.Forms.CheckBox();
            this.checkBoxID7 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBoxID14 = new System.Windows.Forms.CheckBox();
            this.checkBoxID13 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabTracking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonServoOn
            // 
            this.buttonServoOn.Location = new System.Drawing.Point(392, 8);
            this.buttonServoOn.Name = "buttonServoOn";
            this.buttonServoOn.Size = new System.Drawing.Size(75, 23);
            this.buttonServoOn.TabIndex = 0;
            this.buttonServoOn.Text = "ServoOn";
            this.buttonServoOn.UseVisualStyleBackColor = true;
            this.buttonServoOn.Click += new System.EventHandler(this.buttonServoOn_Click);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            // 
            // textBoxServoOn
            // 
            this.textBoxServoOn.Location = new System.Drawing.Point(476, 6);
            this.textBoxServoOn.Name = "textBoxServoOn";
            this.textBoxServoOn.Size = new System.Drawing.Size(48, 19);
            this.textBoxServoOn.TabIndex = 1;
            this.textBoxServoOn.Text = "OFF";
            // 
            // buttonGain
            // 
            this.buttonGain.Location = new System.Drawing.Point(8, 40);
            this.buttonGain.Name = "buttonGain";
            this.buttonGain.Size = new System.Drawing.Size(75, 23);
            this.buttonGain.TabIndex = 2;
            this.buttonGain.Text = "Gain";
            this.buttonGain.UseVisualStyleBackColor = true;
            this.buttonGain.Click += new System.EventHandler(this.buttonGain_Click);
            // 
            // buttonPWMLimit
            // 
            this.buttonPWMLimit.Location = new System.Drawing.Point(8, 72);
            this.buttonPWMLimit.Name = "buttonPWMLimit";
            this.buttonPWMLimit.Size = new System.Drawing.Size(75, 23);
            this.buttonPWMLimit.TabIndex = 3;
            this.buttonPWMLimit.Text = "PWMLimit";
            this.buttonPWMLimit.UseVisualStyleBackColor = true;
            this.buttonPWMLimit.Click += new System.EventHandler(this.buttonPWMLimit_Click);
            // 
            // textBoxGain
            // 
            this.textBoxGain.Location = new System.Drawing.Point(96, 40);
            this.textBoxGain.Name = "textBoxGain";
            this.textBoxGain.Size = new System.Drawing.Size(48, 19);
            this.textBoxGain.TabIndex = 4;
            // 
            // textBoxPWMLimit
            // 
            this.textBoxPWMLimit.Location = new System.Drawing.Point(96, 72);
            this.textBoxPWMLimit.Name = "textBoxPWMLimit";
            this.textBoxPWMLimit.Size = new System.Drawing.Size(48, 19);
            this.textBoxPWMLimit.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(8, 144);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonMargin
            // 
            this.buttonMargin.Location = new System.Drawing.Point(8, 8);
            this.buttonMargin.Name = "buttonMargin";
            this.buttonMargin.Size = new System.Drawing.Size(75, 23);
            this.buttonMargin.TabIndex = 7;
            this.buttonMargin.Text = "Margin";
            this.buttonMargin.UseVisualStyleBackColor = true;
            this.buttonMargin.Click += new System.EventHandler(this.buttonMargin_Click);
            // 
            // textBoxMargin
            // 
            this.textBoxMargin.Location = new System.Drawing.Point(96, 8);
            this.textBoxMargin.Name = "textBoxMargin";
            this.textBoxMargin.Size = new System.Drawing.Size(48, 19);
            this.textBoxMargin.TabIndex = 8;
            // 
            // buttonInitialPos
            // 
            this.buttonInitialPos.Location = new System.Drawing.Point(8, 104);
            this.buttonInitialPos.Name = "buttonInitialPos";
            this.buttonInitialPos.Size = new System.Drawing.Size(75, 23);
            this.buttonInitialPos.TabIndex = 9;
            this.buttonInitialPos.Text = "Initial Pos";
            this.buttonInitialPos.UseVisualStyleBackColor = true;
            this.buttonInitialPos.Click += new System.EventHandler(this.buttonInitialPos_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTracking);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 288);
            this.tabControl1.TabIndex = 10;
            // 
            // tabTracking
            // 
            this.tabTracking.Controls.Add(this.textBox1);
            this.tabTracking.Controls.Add(this.buttonStart);
            this.tabTracking.Controls.Add(this.label1);
            this.tabTracking.Controls.Add(this.numericUpDown1);
            this.tabTracking.Location = new System.Drawing.Point(4, 22);
            this.tabTracking.Name = "tabTracking";
            this.tabTracking.Padding = new System.Windows.Forms.Padding(3);
            this.tabTracking.Size = new System.Drawing.Size(520, 262);
            this.tabTracking.TabIndex = 1;
            this.tabTracking.Text = "Tracking";
            this.tabTracking.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(16, 48);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 24);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 19);
            this.numericUpDown1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.buttonInitialPos);
            this.tabPage1.Controls.Add(this.textBoxMargin);
            this.tabPage1.Controls.Add(this.textBoxPWMLimit);
            this.tabPage1.Controls.Add(this.buttonMargin);
            this.tabPage1.Controls.Add(this.textBoxGain);
            this.tabPage1.Controls.Add(this.buttonGain);
            this.tabPage1.Controls.Add(this.buttonPWMLimit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBoxCommPort
            // 
            this.comboBoxCommPort.FormattingEnabled = true;
            this.comboBoxCommPort.Location = new System.Drawing.Point(8, 8);
            this.comboBoxCommPort.Name = "comboBoxCommPort";
            this.comboBoxCommPort.Size = new System.Drawing.Size(88, 20);
            this.comboBoxCommPort.TabIndex = 11;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(100, 6);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 12;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // checkBoxID1
            // 
            this.checkBoxID1.AutoSize = true;
            this.checkBoxID1.Location = new System.Drawing.Point(8, 40);
            this.checkBoxID1.Name = "checkBoxID1";
            this.checkBoxID1.Size = new System.Drawing.Size(30, 16);
            this.checkBoxID1.TabIndex = 13;
            this.checkBoxID1.Text = "1";
            this.checkBoxID1.UseVisualStyleBackColor = true;
            // 
            // checkBoxID2
            // 
            this.checkBoxID2.AutoSize = true;
            this.checkBoxID2.Location = new System.Drawing.Point(48, 40);
            this.checkBoxID2.Name = "checkBoxID2";
            this.checkBoxID2.Size = new System.Drawing.Size(30, 16);
            this.checkBoxID2.TabIndex = 14;
            this.checkBoxID2.Text = "2";
            this.checkBoxID2.UseVisualStyleBackColor = true;
            // 
            // checkBoxID3
            // 
            this.checkBoxID3.AutoSize = true;
            this.checkBoxID3.Location = new System.Drawing.Point(88, 40);
            this.checkBoxID3.Name = "checkBoxID3";
            this.checkBoxID3.Size = new System.Drawing.Size(30, 16);
            this.checkBoxID3.TabIndex = 15;
            this.checkBoxID3.Text = "3";
            this.checkBoxID3.UseVisualStyleBackColor = true;
            // 
            // checkBoxID4
            // 
            this.checkBoxID4.AutoSize = true;
            this.checkBoxID4.Location = new System.Drawing.Point(128, 40);
            this.checkBoxID4.Name = "checkBoxID4";
            this.checkBoxID4.Size = new System.Drawing.Size(30, 16);
            this.checkBoxID4.TabIndex = 16;
            this.checkBoxID4.Text = "4";
            this.checkBoxID4.UseVisualStyleBackColor = true;
            // 
            // checkBoxID5
            // 
            this.checkBoxID5.AutoSize = true;
            this.checkBoxID5.Location = new System.Drawing.Point(168, 40);
            this.checkBoxID5.Name = "checkBoxID5";
            this.checkBoxID5.Size = new System.Drawing.Size(30, 16);
            this.checkBoxID5.TabIndex = 17;
            this.checkBoxID5.Text = "5";
            this.checkBoxID5.UseVisualStyleBackColor = true;
            // 
            // checkBoxID6
            // 
            this.checkBoxID6.AutoSize = true;
            this.checkBoxID6.Location = new System.Drawing.Point(208, 40);
            this.checkBoxID6.Name = "checkBoxID6";
            this.checkBoxID6.Size = new System.Drawing.Size(30, 16);
            this.checkBoxID6.TabIndex = 18;
            this.checkBoxID6.Text = "6";
            this.checkBoxID6.UseVisualStyleBackColor = true;
            // 
            // checkBoxID12
            // 
            this.checkBoxID12.AutoSize = true;
            this.checkBoxID12.Location = new System.Drawing.Point(448, 40);
            this.checkBoxID12.Name = "checkBoxID12";
            this.checkBoxID12.Size = new System.Drawing.Size(36, 16);
            this.checkBoxID12.TabIndex = 24;
            this.checkBoxID12.Text = "12";
            this.checkBoxID12.UseVisualStyleBackColor = true;
            // 
            // checkBoxID11
            // 
            this.checkBoxID11.AutoSize = true;
            this.checkBoxID11.Location = new System.Drawing.Point(408, 40);
            this.checkBoxID11.Name = "checkBoxID11";
            this.checkBoxID11.Size = new System.Drawing.Size(36, 16);
            this.checkBoxID11.TabIndex = 23;
            this.checkBoxID11.Text = "11";
            this.checkBoxID11.UseVisualStyleBackColor = true;
            // 
            // checkBoxID10
            // 
            this.checkBoxID10.AutoSize = true;
            this.checkBoxID10.Location = new System.Drawing.Point(368, 40);
            this.checkBoxID10.Name = "checkBoxID10";
            this.checkBoxID10.Size = new System.Drawing.Size(36, 16);
            this.checkBoxID10.TabIndex = 22;
            this.checkBoxID10.Text = "10";
            this.checkBoxID10.UseVisualStyleBackColor = true;
            // 
            // checkBoxID9
            // 
            this.checkBoxID9.AutoSize = true;
            this.checkBoxID9.Location = new System.Drawing.Point(328, 40);
            this.checkBoxID9.Name = "checkBoxID9";
            this.checkBoxID9.Size = new System.Drawing.Size(30, 16);
            this.checkBoxID9.TabIndex = 21;
            this.checkBoxID9.Text = "9";
            this.checkBoxID9.UseVisualStyleBackColor = true;
            // 
            // checkBoxID8
            // 
            this.checkBoxID8.AutoSize = true;
            this.checkBoxID8.Location = new System.Drawing.Point(288, 40);
            this.checkBoxID8.Name = "checkBoxID8";
            this.checkBoxID8.Size = new System.Drawing.Size(30, 16);
            this.checkBoxID8.TabIndex = 20;
            this.checkBoxID8.Text = "8";
            this.checkBoxID8.UseVisualStyleBackColor = true;
            // 
            // checkBoxID7
            // 
            this.checkBoxID7.AutoSize = true;
            this.checkBoxID7.Location = new System.Drawing.Point(248, 40);
            this.checkBoxID7.Name = "checkBoxID7";
            this.checkBoxID7.Size = new System.Drawing.Size(30, 16);
            this.checkBoxID7.TabIndex = 19;
            this.checkBoxID7.Text = "7";
            this.checkBoxID7.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(448, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(36, 16);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "24";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(408, 56);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(36, 16);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.Text = "23";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(368, 56);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(36, 16);
            this.checkBox3.TabIndex = 34;
            this.checkBox3.Text = "22";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(328, 56);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(36, 16);
            this.checkBox4.TabIndex = 33;
            this.checkBox4.Text = "21";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(288, 56);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(36, 16);
            this.checkBox5.TabIndex = 32;
            this.checkBox5.Text = "20";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(248, 56);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(36, 16);
            this.checkBox6.TabIndex = 31;
            this.checkBox6.Text = "19";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(208, 56);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(36, 16);
            this.checkBox7.TabIndex = 30;
            this.checkBox7.Text = "18";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(168, 56);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(36, 16);
            this.checkBox8.TabIndex = 29;
            this.checkBox8.Text = "17";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(128, 56);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(36, 16);
            this.checkBox9.TabIndex = 28;
            this.checkBox9.Text = "16";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(88, 56);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(36, 16);
            this.checkBox10.TabIndex = 27;
            this.checkBox10.Text = "15";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBoxID14
            // 
            this.checkBoxID14.AutoSize = true;
            this.checkBoxID14.Location = new System.Drawing.Point(48, 56);
            this.checkBoxID14.Name = "checkBoxID14";
            this.checkBoxID14.Size = new System.Drawing.Size(36, 16);
            this.checkBoxID14.TabIndex = 26;
            this.checkBoxID14.Text = "14";
            this.checkBoxID14.UseVisualStyleBackColor = true;
            // 
            // checkBoxID13
            // 
            this.checkBoxID13.AutoSize = true;
            this.checkBoxID13.Location = new System.Drawing.Point(8, 56);
            this.checkBoxID13.Name = "checkBoxID13";
            this.checkBoxID13.Size = new System.Drawing.Size(36, 16);
            this.checkBoxID13.TabIndex = 25;
            this.checkBoxID13.Text = "13";
            this.checkBoxID13.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 224);
            this.textBox1.TabIndex = 3;
            // 
            // FormMotorControllerCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 375);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBoxID14);
            this.Controls.Add(this.checkBoxID13);
            this.Controls.Add(this.checkBoxID12);
            this.Controls.Add(this.checkBoxID11);
            this.Controls.Add(this.checkBoxID10);
            this.Controls.Add(this.checkBoxID9);
            this.Controls.Add(this.checkBoxID8);
            this.Controls.Add(this.checkBoxID7);
            this.Controls.Add(this.checkBoxID6);
            this.Controls.Add(this.checkBoxID5);
            this.Controls.Add(this.checkBoxID4);
            this.Controls.Add(this.checkBoxID3);
            this.Controls.Add(this.checkBoxID2);
            this.Controls.Add(this.checkBoxID1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxCommPort);
            this.Controls.Add(this.buttonServoOn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxServoOn);
            this.Name = "FormMotorControllerCheck";
            this.Text = "MotorControllerCheck";
            this.tabControl1.ResumeLayout(false);
            this.tabTracking.ResumeLayout(false);
            this.tabTracking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonServoOn;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBoxServoOn;
        private System.Windows.Forms.Button buttonGain;
        private System.Windows.Forms.Button buttonPWMLimit;
        private System.Windows.Forms.TextBox textBoxGain;
        private System.Windows.Forms.TextBox textBoxPWMLimit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonMargin;
        private System.Windows.Forms.TextBox textBoxMargin;
        private System.Windows.Forms.Button buttonInitialPos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabTracking;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxCommPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.CheckBox checkBoxID1;
        private System.Windows.Forms.CheckBox checkBoxID2;
        private System.Windows.Forms.CheckBox checkBoxID3;
        private System.Windows.Forms.CheckBox checkBoxID4;
        private System.Windows.Forms.CheckBox checkBoxID5;
        private System.Windows.Forms.CheckBox checkBoxID6;
        private System.Windows.Forms.CheckBox checkBoxID12;
        private System.Windows.Forms.CheckBox checkBoxID11;
        private System.Windows.Forms.CheckBox checkBoxID10;
        private System.Windows.Forms.CheckBox checkBoxID9;
        private System.Windows.Forms.CheckBox checkBoxID8;
        private System.Windows.Forms.CheckBox checkBoxID7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBoxID14;
        private System.Windows.Forms.CheckBox checkBoxID13;
        private System.Windows.Forms.TextBox textBox1;
    }
}

