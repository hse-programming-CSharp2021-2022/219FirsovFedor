using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public bool flag = true;
        public Form1()
        {
            InitializeComponent();
            label1.Font = new System.Drawing.Font("Arial", 24);
            label1.ForeColor = Color.DeepPink;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text != "" && flag)
            {
                string buf = "";
                for (int i = 0; i < label1.Text.Length - 1; ++i)
                    buf += label1.Text[i];
                label1.Text = buf;
            }
            else if (this.Opacity != 0 && flag)
            {
                this.Opacity -= .1;
            }
            else if(this.Opacity == 0 && flag)
            {
                label1.Text = "Всё дозволено.";
                flag = false;
            }
            else
            {
                this.Opacity += .1;
            }
        }
    }
}
