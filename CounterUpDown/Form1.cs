namespace CounterUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, res;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox1.Text);
            res = n1 + 1;
            textBox1.Text = res.ToString();
        }

        private void n2_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, res;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox1.Text);
            res = n2 - 1;
            textBox1.Text = res.ToString();
        }

        private void n3_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, res;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox1.Text);
            res = n3 = 0;
            textBox1.Text = res.ToString();
        }
    }
}
