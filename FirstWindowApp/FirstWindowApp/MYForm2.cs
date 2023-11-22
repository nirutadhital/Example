using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowApp
{
    public partial class MYForm2 : Form
    {
        public MYForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AboutBox1 a = new AboutBox1();
            //a.ShowDialog();
            Panel p = new Panel();
            p.Show();
            p.Hide();



        }

        private void DialogBox_Apply(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Panel p = new Panel();
            p.Show();
            p.Hide();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }
    }
}
