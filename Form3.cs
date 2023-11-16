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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private Form2 form2;

        int a = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("모든 목록을 체크하세요");
            }
            else if (radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("모든 목록을 체크하세요");
            }
            else if (radioButton5.Checked == false && radioButton6.Checked == false)
            {
                MessageBox.Show("모든 목록을 체크하세요");
            }
            else
            {
                Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {


        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
