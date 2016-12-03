using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using B3MLib;

namespace STM_MotorController_check
{
    public partial class FormMotorControllerCheck : Form
    {
        int step = 0;
        int target = 0;
        bool isServoOn = false;
        int count = 0;

        public FormMotorControllerCheck()
        {
            InitializeComponent();
            serialPort.Open();
            serialPort.ReadTimeout = 5;
        }

        private void buttonServoOn_Click(object sender, EventArgs e)
        {
            byte[] parameter = new byte[3 * 14];
            if (isServoOn)
            {
                for(int i = 0; i < 14; i++){
                    parameter[i * 3] = (byte)(i + 1);
                    parameter[i * 3 + 1] = 0x01;
                }
                textBoxServoOn.Text = "OFF";
                textBoxServoOn.BackColor = Color.White;
            }
            else
            {
                for(int i = 0; i < 14; i++){
                    parameter[i * 3] = (byte)(i + 1);
                }
                textBoxServoOn.Text = "ON";
                textBoxServoOn.BackColor = Color.Red;
            }
            isServoOn = !isServoOn;
            byte[] cmd = B3MLib.B3MLib.Write(
                0,
                0x28,
                14,
                parameter
            );

            if (B3MLib.B3MLib.Synchronize(serialPort, cmd) == false)
            {
                MessageBox.Show("サーボへのコマンドの送信に失敗しました．");
                Close();
            }
        }

        private void buttonGain_Click(object sender, EventArgs e)
        {
            byte[] parameter = new byte[5 * 14];
            for (int i = 0; i < 14; i++)
            {
                parameter[i * 5] = (byte)(i + 1);
                int gain = int.Parse(textBoxGain.Text);
                parameter[i * 5 + 1] = (byte)(gain & 0xff);
                parameter[i * 5 + 2] = (byte)((gain >> 8) & 0xff);
                parameter[i * 5 + 3] = (byte)((gain >> 16) & 0xff);
                parameter[i * 5 + 4] = (byte)((gain >> 24) & 0xff);
            }
            byte[] cmd = B3MLib.B3MLib.Write(
                0,
                0x5E,
                14,
                parameter
            );

            if (B3MLib.B3MLib.Synchronize(serialPort, cmd) == false)
            {
                MessageBox.Show("サーボへのコマンドの送信に失敗しました．");
                Close();
            }
        }

        private void buttonPWMLimit_Click(object sender, EventArgs e)
        {
            byte[] parameter = new byte[2 * 14];
            for (int i = 0; i < 14; i++)
            {
                parameter[i * 2] = (byte)(i + 1);
                parameter[i * 2 + 1] = byte.Parse(textBoxPWMLimit.Text);
            }
            byte[] cmd = B3MLib.B3MLib.Write(
                0,
                0x1B,
                14,
                parameter
            );

            if (B3MLib.B3MLib.Synchronize(serialPort, cmd) == false)
            {
                MessageBox.Show("サーボへのコマンドの送信に失敗しました．");
                Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 14; i++)
            {
                byte[] cmd = B3MLib.B3MLib.Save(
                    0,
                    (byte)(i + 1)
                );

                if (B3MLib.B3MLib.Synchronize(serialPort, cmd) == false)
                {
                    MessageBox.Show("サーボへのコマンドの送信に失敗しました．");
                    Close();
                }
            }
        }

        private void buttonMargin_Click(object sender, EventArgs e)
        {
            byte[] parameter = new byte[3 * 14];
            for (int i = 0; i < 14; i++)
            {
                parameter[i * 3] = (byte)(i + 1);
                int margin = int.Parse(textBoxMargin.Text);
                parameter[i * 3 + 1] = (byte)(margin & 0xff);
                parameter[i * 3 + 2] = (byte)((margin >> 8) & 0xff);
            }
            byte[] cmd = B3MLib.B3MLib.Write(
                0,
                0x1C,
                14,
                parameter
            );

            if (B3MLib.B3MLib.Synchronize(serialPort, cmd) == false)
            {
                MessageBox.Show("サーボへのコマンドの送信に失敗しました．");
                Close();
            }
        }

        private void buttonInitialPos_Click(object sender, EventArgs e)
        {
            byte[] parameter = new byte[3 * 14];
            for (int i = 0; i < 14; i++)
            {
                parameter[i * 3] = (byte)(i + 1);
                parameter[i * 3 + 1] = 0;
                parameter[i * 3 + 2] = 0;
            }
            byte[] cmd = B3MLib.B3MLib.Write(
                0,
                0x2A,
                14,
                parameter
            );

            if (B3MLib.B3MLib.Synchronize(serialPort, cmd) == false)
            {
                MessageBox.Show("サーボへのコマンドの送信に失敗しました．");
                Close();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled) timer1.Start();
            else timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (step >= 50)
            {
                if (target == 0) target = 500;
                else target = 0;
                step = 0;

                byte[] cmd = B3MLib.B3MLib.WriteSingle(
                    0,
                    B3MLib.B3MLib.SERVO_DESIRED_POSITION,
                    1,
                    new byte[] { (byte)(target & 0xff), (byte)(target >> 8) }
                );

                if (B3MLib.B3MLib.Synchronize(serialPort, cmd) == false)
                {
                    MessageBox.Show("サーボへのコマンドの送信に失敗しました．");
                    Close();
                }
            }

            if (step > 0){
                byte[] rx = new byte[7];
                byte[] cmd = B3MLib.B3MLib.Read(
                    0,
                    B3MLib.B3MLib.SERVO_CURRENT_POSITION,
                    2,
                    1
                );
                if (B3MLib.B3MLib.Synchronize(serialPort, cmd, ref rx) == false)
                {
                    textBox1.Text += "サーボへのコマンドの送信に失敗しました．\r\n";
//                    MessageBox.Show("サーボへのコマンドの送信に失敗しました．");
//                    Close();

                }
//                short angle = (short)Extensions.Converter.ByteConverter.ByteArrayToInt16(rx[4], rx[5]);

/*                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(@"data.csv", true);
                    sw.Write(count * 0.01);
                    sw.Write(", ");
                    sw.Write(target);
                    sw.Write(", ");
                    sw.Write(angle-11200);
                    sw.Write("\r\n");
                    sw.Close();
                    count++;
                }*/
            }
            step++;
        }
    }
}
