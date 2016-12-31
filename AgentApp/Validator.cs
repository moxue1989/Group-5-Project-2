using System;
using System.Windows.Forms;

// for TextBox

namespace AgentApp
{
    public static class Validator
    {
        //Checks if textbox is not empty
        public static bool IsPresent(TextBox tb)
        {
            ErrorProvider e = new ErrorProvider();
            if (tb.Text != "")
            {
                e.SetError(tb, null);
                return true;
            }
            else
            {
               
                e.SetError(tb, @"The " + tb.Tag + @" field is required.");
                //MessageBox.Show(@"The " + tb.Tag + @" field is required.", @"Entry Error", MessageBoxButtons.OK,
                //    MessageBoxIcon.Error); // Show error message when txtbox is empty
                tb.Focus();
                return false;
            }
        }

        //Checks if the textbox contains a int number
        public static bool IsInt(TextBox tb, int min)
        {
            int num; //auxillary for tring to parse
            decimal value = Convert.ToDecimal(tb.Text);
           
                if (Int32.TryParse(tb.Text, out num) && value >= min)
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + @" must be a positive number.", @"Entry Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error); // Show error message when not a number
                tb.Focus();
                return false;
            }
        }

        //Checks if the textbox contains a decimal number
        public static bool IsDecimal(TextBox tb)
        {
            decimal num; //auxillary for tring to parse
            if (Decimal.TryParse(tb.Text, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + @" must be a number.", @"Entry Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error); // Show error message when not a number
                tb.Focus();
                return false;
            }
        }

        //Checks if Decimal value in textbox is within given range
        public static bool IsPositiveDeci(TextBox tb, decimal min)
        {
            decimal value = Convert.ToDecimal(tb.Text);
            if (value >= min)
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + @" must be equal to or above " + min + @".", @"Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb.Focus();
                return false;
            }

        }

        public static bool IsPositiveNum(TextBox tb, int min)
        {
            
            int value = Convert.ToInt32(tb.Text);
            if (value >= min)
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + @" must be a positve number " + min + @".", @"Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb.Focus();
                return false;
            }

        }
    }
}
