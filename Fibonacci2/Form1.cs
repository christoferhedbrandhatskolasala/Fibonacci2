using Accessibility;

namespace Fibonacci2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int prevPrevNumber = 0; // tjoho
            int prevNumber = 1;


            textBox3.Text = "0 1 ";

            for (int i = 0; i < 30; i++)
            {
                int newNumber = prevNumber + prevPrevNumber;
                textBox3.Text = textBox3.Text + newNumber + " ";

                prevPrevNumber = prevNumber;
                prevNumber = newNumber;
            }

        }
    }
}