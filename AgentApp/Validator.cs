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
            if (tb.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(@"The " + tb.Tag + @" field is required", @"Entry Error");// Show error message when txtbox is empty
                tb.Focus();
                return false;
            }
        }

        //Checks if the textbox contains a int number
        public static bool IsInt(TextBox tb)
        {
            int num; //auxillary for tring to parse
            if (Int32.TryParse(tb.Text, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + @" must be positive number", @"Entry Error");// Show error message when not a number
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
                MessageBox.Show(tb.Tag + @" must be number", @"Entry Error");// Show error message when not a number
                tb.Focus();
                return false;
            }
        }
        //Checks if Decimal value in textbox is within given range
        public static bool IsWithinRange(TextBox tb, decimal min)
        {
            decimal value = Convert.ToDecimal(tb.Text);
            if (value >= min)
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + @" must be equal to or above " + min, @"Entry Error");
                tb.Focus();
                return false;
            }

        }
    }
}
