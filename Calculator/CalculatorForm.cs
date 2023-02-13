using System.Windows.Forms;
using System;
using CalculatorLibary;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private double _result = 0;
        private string _operation = "";
        private bool _isOperationPerformed = false;
        private Libary _libary;

        public CalculatorForm()
        {
            InitializeComponent();
            _libary = new Libary();
        }

        private void NumberClick(object sender, EventArgs e)
        {
            if (Input.Text == "0" || _isOperationPerformed)
            {
                Input.Clear();
            }

            _isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!Input.Text.Contains("."))
                {
                    Input.Text = Input.Text + button.Text;
                }
            }

            else
            {
                Input.Text = Input.Text + button.Text;
            }
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_result != 0)
            {
                EqualB.PerformClick();
                _operation = button.Text;
                _isOperationPerformed = true;
                label.Text = _result + " " + _operation;
            }

            else
            {
                _operation = button.Text;
                _result = Convert.ToDouble(Input.Text);
                _isOperationPerformed = true;
                label.Text = _result + " " + _operation;
            }
        }

        private void CEClick(object sender, EventArgs e)
        {
            Input.Text = "0";
        }

        private void CClick(object sender, EventArgs e)
        {
            Input.Text = "0";
            _result = 0;
        }

        private void EqualClick(object sender, EventArgs e)
        {
            label.Text = "";
            Input.Text = _libary.Operation(_result, Convert.ToDouble(Input.Text), _operation).ToString();
            _result = Convert.ToDouble(Input.Text);
            _operation = "";
        }
    }
}
