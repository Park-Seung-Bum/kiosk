using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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
            else
            {
                Close();
            }
        }
    }
}
