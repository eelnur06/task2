namespace _5094a2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            int number1 = Convert.ToInt32(number1MaskedTextBox.Text);
            int number2 = Convert.ToInt32(number2MaskedTextBox.Text);

            string pickedOperator = operatorComboBox1.Text;

            if (pickedOperator == "-")
            {
                result = number1 - number2;
            }
            else if (pickedOperator == "+")
            {
                result = number1 + number2;
            }
            else if (pickedOperator == "/")
            {
                result = number1 / number2;
            }
            else if (pickedOperator == "*")
            {
                result = number1 * number2;
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa operator seçin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            label4.Text = "Answer: " + result.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            number1MaskedTextBox.Clear();
            number2MaskedTextBox.Clear();
            operatorComboBox1.SelectedIndex = -1;
            label4.Text = "Answer: 0";
        }
    }
}
