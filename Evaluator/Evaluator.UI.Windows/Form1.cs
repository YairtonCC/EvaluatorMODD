using Evaluator.Core;

namespace Evaluator.UI.Windows

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void bparentesisabrir_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
        }

        private void bparentesiscerrar_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void basterisco_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*";
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void bslash_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void bmas_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void bmenos_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }

        private void bcomilla_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void bpunto_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void bigual_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = txtDisplay.Text;
                double result = ExpressionEvaluator.Evaluate(expression);

                txtDisplay.Text = expression + Environment.NewLine + "= " + result.ToString();
            }
            catch
            {
                txtDisplay.Text = txtDisplay.Text + Environment.NewLine + "= Syntax Error";
            }
        }
}
}