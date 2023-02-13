using System;
using System.Windows.Forms;

namespace CalculatorLibary
{
    public class Libary
    {
        public double Operation(double num1, double num2, string operation)
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        return num1 + num2;

                    case "-":
                        return num1 - num2;

                    case "*":
                        return num1 * num2;

                    case "/":
                        return num1 / num2;

                    default:
                        break;
                }
            }

            catch(DivideByZeroException)
            {
                MessageBox.Show("Can not divide with 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }
    }
}
