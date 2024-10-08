namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int res = num1 * num2;

                Result.Text = res.ToString();
                Result.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Enter Both fiedls!!");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int res = num1 + num2;

                Result.Text = res.ToString();
                Result.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Enter Both fiedls!!");
            }

            //MessageBox.Show("Addition result is: " + res.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int res = num1 - num2;

                Result.Text = res.ToString();
                Result.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Enter Both fiedls!!");
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int res = num1 / num2;

                Result.Text = res.ToString();
                Result.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Enter Both fiedls!!");
            }
        }
    }
}
