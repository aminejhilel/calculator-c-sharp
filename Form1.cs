namespace calculator
{
    public partial class Form1 : Form
    {
        double n1, n2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            result = n1 + n2;
            lb_result.Text = result.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            result = n1 - n2;
            lb_result.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            result = n1 * n2;
            lb_result.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            result = n1 / n2;
            lb_result.Text = result.ToString();
        }
    }
}
