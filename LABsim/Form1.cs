using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABsim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxSB.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            labelSUM.Text = "SUM = " + Convert.ToString(SB1.Value + SB2.Value);
            TB1.Text = Convert.ToString(SB1.Value);
        }

        private void SB2_Scroll(object sender, ScrollEventArgs e)
        {
            labelSUM.Text = "SUM = " + Convert.ToString(SB1.Value + SB2.Value);
            TB2.Text = Convert.ToString(SB2.Value);
        }
        private int Time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Time++;
            if (Time == 1)
            {
                timer1.Start();
                buttonTimer.Enabled = false;
            }
            if (Time < 10)
            {
                buttonTimer.Text = Convert.ToString(Time) + " сек";
            }
            if (Time == 10)
            {
                timer1.Stop();
                MessageBox.Show("Завершенно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonTimer.Enabled = true;
                Time = 0;
                buttonTimer.Text = "*Клац*";
            }
        }
            private void buttonTimer_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Height += 15;
            this.Width += 15;
        }

        private void buttonSizeDown_Click(object sender, EventArgs e)
        {
            this.Height -= 15;
            this.Width -= 15;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonPictureLeft_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(BMP;JPG;GIF;PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files(*.*)|*.*";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RB = (RadioButton)sender;
            if (RB.Checked)
            {
                MessageBox.Show("Вы выбрали " + RB.Text);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RB = (RadioButton)sender;
            if (RB.Checked)
            {
                MessageBox.Show("Вы выбрали " + RB.Text);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RB = (RadioButton)sender;
            if (RB.Checked)
            {
                MessageBox.Show("Вы выбрали " + RB.Text);
            }
        }

        private string[] SBmas = { "Ужасно", "Неплохо", "Нормально", "Хорошо", "Отлично" };
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxSB.Text = SBmas[trackBar1.Value];
        }


        private void textBoxSB_TextChanged(object sender, EventArgs e)
        {
            textBoxSB.ReadOnly = true;
        }

        private void createButton()
        {
            flowLayoutPanel1.Controls.Clear();

            for (int i = 0; i < 4; i++)
            {
                Button b = new Button();
                b.Tag = i;
                b.Width = 100;
                b.Height = 30;
                b.Left = 400;
                b.Top = 300;
                b.Parent = this;
                b.Text = "Кнопка " + i.ToString();
                b.Name = "Nbutt"+i.ToString();
                flowLayoutPanel1.Controls.Add(b);
                b.Click += new EventHandler(NewButton_Click);
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            for (int i = 0; i < 4; i++)
            {
                if (btn.Name == ("Nbutt" + i))
                {

                    btn.BackColor = System.Drawing.Color.Red;

                    break;
                }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            createButton();
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
