using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0519
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "堀 朱莉";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Top = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Visible == true)//表示されている場合
            {
                button4.BackColor = Color.Yellow;
                button4.ForeColor = Color.Black;
                label1.Visible = false;
            }
            else//されていない場合
            {
                button4.BackColor = Color.Green;
                button4.ForeColor = Color.White;
                label1.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "ボタンを押すと消えるよ"; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
