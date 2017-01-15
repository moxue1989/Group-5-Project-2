using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // for TextBox

namespace Agent_App_V2
{
    public static class Validator
    {
        public static bool IsValidDate(DateTimePicker startDate, DateTimePicker endDate)
        {
            bool validStatus = true;
            // check if start date is in the future
            if (startDate.Value < DateTime.Now)
            {
                // display error message
                MessageBox.Show(startDate.Tag + " must be later than today!", "input Error");
                startDate.Focus();
                validStatus = false;
            }
            // check if start date is later than end date
            else if (startDate.Value > endDate.Value)
            {
                // display error message
                MessageBox.Show(endDate.Tag + " must be later than " + startDate.Tag + "!", "input Error");
                startDate.Focus();
                validStatus = false;
            }
            return validStatus;
        }


        // checks if text box is empty
        public static bool IsPresent(TextBox tb)
        {
            if(tb.Text != "")
            {
                return true;
            }
            else
            {
                // display empty error message
                MessageBox.Show(tb.Tag + " is required!", "input Error");
                tb.Focus();
                return false;
            }
        }

        // checks if text box contains decimal number
        public static bool IsDecimal(TextBox tb)
        {
            decimal num; // auxillary for trying parse
            if(Decimal.TryParse(tb.Text.Trim('$'), out num))
            {
                return true;
            }
            else
            {
                // display decimal error message
                MessageBox.Show(tb.Tag + " has to be decimal value!", "input Error");
                tb.Focus();
                return false;
            }
        }

        // checks if decimal in text box is within range from min to max
        public static bool IsWithinRange(TextBox tb, decimal min, decimal max)
        {
            decimal value = Convert.ToDecimal(tb.Text.Trim('$'));
            if (value >= min && value <= max)
            {
                return true;
            }
            else
            {
                // display range error message
                MessageBox.Show(tb.Tag + " must be within range: " + min + ".." + max, "input Error");
                tb.Focus();
                return false;
            }
        }

        // check if value in first textbox is lower than second textbox
        public static bool IsLower(TextBox lowTb, TextBox highTb)
        {
            decimal lowValue = Convert.ToDecimal(lowTb.Text.Trim('$'));
            decimal highValue = Convert.ToDecimal(highTb.Text.Trim('$'));
            if (lowValue >= highValue)
            {
                MessageBox.Show(lowTb.Tag + " has to be less than " + highTb.Tag +"!", "input Error");
                lowTb.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        // checks if text box contains integer number
        public static bool IsInt(TextBox tb)
        {
            int num; // auxillary for trying parse
            if (Int32.TryParse(tb.Text, out num))
            {
                return true;
            }
            else
            {
                // display decimal error message
                MessageBox.Show(tb.Tag + " has to be Integer value!", "input Error");
                tb.Focus();
                return false;
            }
        }

        // checks if text box is between minimum and maximum amount of allowed characters
        public static bool IsWithinLength(TextBox tb, int min, int max)
        {
            if(tb.Text.Length >= min && tb.Text.Length <= max)
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " must be within range: " + min + ".." + max + " number of characters", "input Error");
                tb.Focus();
                return false;
            }
        }

        // checks if Rich text box is empty
        public static bool IsPresent(RichTextBox tb)
        {
            if (tb.Text != "")
            {
                return true;
            }
            else
            {
                // display empty error message
                MessageBox.Show(tb.Tag + " is required!", "input Error");
                tb.Focus();
                return false;
            }
        }

        // checks if text box is between minimum and maximum amount of allowed characters
        public static bool IsWithinLength(RichTextBox tb, int min, int max)
        {
            if (tb.Text.Length >= min && tb.Text.Length <= max)
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " must be within range: " + min + ".." + max + " number of characters", "input Error");
                tb.Focus();
                return false;
            }
        }
    }
}
