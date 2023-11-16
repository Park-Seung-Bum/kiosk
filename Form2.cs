using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace kiosk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            setting();
        }


        private Form4 form4;
        private Form3 form3;
        private Form5 form5;
        int sum = 0;
        int m = 0;
        int t = 0;
        PictureBox[] pb = new PictureBox[6];
        Label[] lb = new Label[6];
        public void setting()
        {
            pb[0] = pickMenu1;
            pb[1] = pickMenu2;
            pb[2] = pickMenu3;
            pb[3] = pickMenu4;
            pb[4] = pickMenu5;
            pb[5] = pickMenu6;

            lb[0] = label18;
            lb[1] = label19;
            lb[2] = label20;
            lb[3] = label21;
            lb[4] = label22;
            lb[5] = label23;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += label2.Text + ", ";
            sum += 2000;
            textBox2.Text = string.Format("{0}", sum);


            form3 = new Form3();
            form3.Show();

            if (m < 6)
            {
                lb[m].Text = label2.Text;
                pb[m].Image = button1.Image;
                m++;
            }
            t++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label3.Text;
                pb[m].Image = button2.Image;
                m++;
            }
            textBox1.Text += label3.Text + ", ";
            sum += 3400;
            textBox2.Text = string.Format("{0}", sum);
            form3 = new Form3();
            form3.Show();


            t++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label4.Text;
                pb[m].Image = button3.Image;
                m++;
            }
            textBox1.Text += label4.Text + ", ";
            sum += 3500;
            textBox2.Text = string.Format("{0}", sum);
            form3 = new Form3();
            form3.Show();
            t++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label5.Text;
                pb[m].Image = button4.Image;
                m++;
            }
            textBox1.Text += label5.Text + ", ";
            sum += 3700;
            textBox2.Text = string.Format("{0}", sum);
            form3 = new Form3();
            form3.Show();
            t++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label6.Text;
                pb[m].Image = button5.Image;
                m++;
            }
            textBox1.Text += label6.Text + ", ";
            sum += 3200;
            textBox2.Text = string.Format("{0}", sum);
            form3 = new Form3();
            form3.Show();
            t++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label7.Text;
                pb[m].Image = button6.Image;
                m++;
            }
            textBox1.Text += label7.Text + ", ";
            sum += 3700;
            textBox2.Text = string.Format("{0}", sum);
            form3 = new Form3();
            form3.Show();
            t++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label8.Text;
                pb[m].Image = button7.Image;
                m++;
            }
            textBox1.Text += label8.Text + ", ";
            sum += 3300;
            textBox2.Text = string.Format("{0}", sum);
            form3 = new Form3();
            form3.Show();
            t++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label9.Text;
                pb[m].Image = button8.Image;
                m++;
            }
            textBox1.Text += label9.Text + ", ";
            sum += 3900;
            textBox2.Text = string.Format("{0}", sum);
            form3 = new Form3();
            form3.Show();
            t++;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            t = 0;
            sum = 0;
            m = 0;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

            pickMenu1.Image = null;
            pickMenu2.Image = null;
            pickMenu3.Image = null;
            pickMenu4.Image = null;
            pickMenu5.Image = null;
            pickMenu6.Image = null;

            label18.Text = string.Empty;
            label19.Text = string.Empty;
            label20.Text = string.Empty;
            label21.Text = string.Empty;
            label22.Text = string.Empty;
            label23.Text = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label17.Text;
                pb[m].Image = button16.Image;
                m++;
            }
            textBox1.Text += label17.Text + ", ";
            sum += 3200;
            textBox2.Text = string.Format("{0}", sum);
            form5 = new Form5();
            form5.Show();
            t++;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label16.Text;
                pb[m].Image = button15.Image;
                m++;
            }
            textBox1.Text += label16.Text + ", ";
            sum += 4600;
            textBox2.Text = string.Format("{0}", sum);
            form5 = new Form5();
            form5.Show();
            t++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label15.Text;
                pb[m].Image = button14.Image;
                m++;
            }
            textBox1.Text += label15.Text + ", ";
            sum += 4000;
            textBox2.Text = string.Format("{0}", sum);
            form5 = new Form5();
            form5.Show();
            t++;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label14.Text;
                pb[m].Image = button13.Image;
                m++;
            }
            textBox1.Text += label14.Text + ", ";
            sum += 3800;
            textBox2.Text = string.Format("{0}", sum);
            form5 = new Form5();
            form5.Show();
            t++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label13.Text;
                pb[m].Image = button12.Image;
                m++;
            }
            textBox1.Text += label13.Text + ", ";
            sum += 4500;
            textBox2.Text = string.Format("{0}", sum);
            form5 = new Form5();
            form5.Show();
            t++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label12.Text;
                pb[m].Image = button11.Image;
                m++;
            }
            textBox1.Text += label12.Text + ", ";
            sum += 3500;
            textBox2.Text = string.Format("{0}", sum);
            form5 = new Form5();
            form5.Show();
            t++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label11.Text;
                pb[m].Image = button10.Image;
                m++;
            }
            textBox1.Text += label11.Text + ", ";
            sum += 4000;
            textBox2.Text = string.Format("{0}", sum);
            form5 = new Form5();
            form5.Show();
            t++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label10.Text;
                pb[m].Image = button9.Image;
                m++;
            }
            textBox1.Text += label10.Text + ", ";
            sum += 3900;
            textBox2.Text = string.Format("{0}", sum);
            form5 = new Form5();
            form5.Show();
            t++;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label33.Text;
                pb[m].Image = button32.Image;
                m++;
            }
            textBox1.Text += label33.Text + ", ";
            sum += 2500;
            textBox2.Text = string.Format("{0}", sum);
            t++;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label32.Text;
                pb[m].Image = button31.Image;
                m++;
            }
            textBox1.Text += label32.Text + ", ";
            sum += 3500;
            textBox2.Text = string.Format("{0}", sum);
            t++;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label31.Text;
                pb[m].Image = button30.Image;
                m++;
            }
            textBox1.Text += label31.Text + ", ";
            sum += 4500;
            textBox2.Text = string.Format("{0}", sum);
            t++;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label30.Text;
                pb[m].Image = button29.Image;
                m++;
            }
            textBox1.Text += label30.Text + ", ";
            sum += 3500;
            textBox2.Text = string.Format("{0}", sum);
            t++;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label29.Text;
                pb[m].Image = button28.Image;
                m++;
            }
            textBox1.Text += label29.Text + ", ";
            sum += 3500;
            textBox2.Text = string.Format("{0}", sum);
            t++;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label28.Text;
                pb[m].Image = button27.Image;
                m++;
            }
            textBox1.Text += label28.Text + ", ";
            sum += 5000;
            textBox2.Text = string.Format("{0}", sum);
            t++;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label27.Text;
                pb[m].Image = button26.Image;
                m++;
            }
            textBox1.Text += label27.Text + ", ";
            sum += 4500;
            textBox2.Text = string.Format("{0}", sum);
            t++;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                lb[m].Text = label26.Text;
                pb[m].Image = button25.Image;
                m++;
            }
            textBox1.Text += label26.Text + ", ";
            sum += 2500;
            textBox2.Text = string.Format("{0}", sum);
            t++;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (m == 0)
            {
                MessageBox.Show("음료나 디저트를 담으세요");
            }
            else
            {
                MessageBox.Show($"총{t}개 총금액:{sum}");
                form4 = new Form4();
                form4.Show();
                form4.SetCost(sum);
                Hide();
            }

        }


    }
}
