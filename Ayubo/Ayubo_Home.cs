using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo
{
    public partial class Ayubo_Home : Form
    {
        public Ayubo_Home()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            customer frm2 = new customer();
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Day_tour frm2 = new Day_tour();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Long_tour frm2 = new Long_tour();
            frm2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Package frm2 = new Package();
            frm2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 frm2 = new Form5();
            frm2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 frm2 = new Form1();
            frm2.ShowDialog();
        }
    }

    
}
