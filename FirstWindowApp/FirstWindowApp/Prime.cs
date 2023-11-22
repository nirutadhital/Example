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
    public partial class Prime : Form
    {
        public Prime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int n=Convert.ToInt32(textBox1.Text);
            Boolean flag = true;
            for (int i = 2; i <= n / 2; i++)
            {
                if(n%i==0)
                {
                    flag = false;
                    break;
                }

            }
            if(flag)
            {
                DialogResult dr = MessageBox.Show("The Number is Prime");
            }
            else
            {
                DialogResult dr = MessageBox.Show("The Number is not Prime");

            }





        }
    }
}
