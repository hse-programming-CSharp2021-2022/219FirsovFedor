using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task08
{
    public partial class Form1 : Form
    {
        int W = 160;
        int H = 80;
        int X = 0;
        int Y = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Y = trackBar2.Value;
            Invalidate();
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            X = trackBar1.Value;

            Invalidate();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            trackBar2.Value = trackBar2.Minimum;
            BackColor = Color.Black;
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            trackBar1.Maximum = Width - W;
            trackBar2.Maximum = Height - H;
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDark), X, Y, W, H);

            TransparencyKey = SystemColors.ControlDark;
        }
    }
}
