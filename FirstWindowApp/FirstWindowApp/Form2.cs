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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("hello Niruta, How are you?", "Coding", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if(dr.Equals(DialogResult.Yes))
            {
                label1.Text = dr.ToString();

            }
        }
    }
}
