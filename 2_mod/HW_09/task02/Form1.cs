using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task02
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void butdefault_Click(object sender, EventArgs e)
        {
            
            string[] dur = new string[]{ "Ezio Auditore da Firenze", "Altair Ibn-LaʼAhad", "Haytham Kenway", "Edward James Kenway", "Shay Patrick Cormac", "Arno Victor Dorian", "Eivor Varinsdottir" };
            listBox1.Items.Clear();
            listBox1.Items.AddRange(dur);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void butDell_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
