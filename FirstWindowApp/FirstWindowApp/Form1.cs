namespace FirstWindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 n1=Convert.ToInt32(textBox1.Text);
            Int32 n2=Convert.ToInt32(textBox2.Text);
            int n3 = n1 + n2;
            textBox3.Text = n3.ToString();
        }
    }
}