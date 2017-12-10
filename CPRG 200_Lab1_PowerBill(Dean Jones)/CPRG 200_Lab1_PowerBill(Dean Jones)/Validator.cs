using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG_200_Lab1_PowerBill_Dean_Jones_
{
    public static class Validator
    {
        // Validate (empty textbox)
        public static bool IsPresent(TextBox tb)
        {
            if(tb.Text != "")   //Test if EMPTY STRING in TEXTBOX
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " is empty and is required", "Input Error");
                tb.Focus();     //Put FOCUS back to where ERROR happened.
                return false;
            }
        }

        // Validate (is a double)
        public static bool IsDouble(TextBox tb)
        {
            double num;    // test for trying parse
            if (Double.TryParse(tb.Text, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " has to be a double value", "Input Error");
                tb.Focus();     //Put FOCUS back to where ERROR happened.
                return false;
            }
        }

        // Validate (is a decimal)
        public static bool IsDecimal(TextBox tb)
        {
            decimal num;    // test for trying parse
            if(Decimal.TryParse(tb.Text, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " has to be a decimal value", "Input Error");
                tb.Focus();     //Put FOCUS back to where ERROR happened.
                return false;
            }
        }

        // Validate (is in reasonable range)
        public static bool IsWithinRange(TextBox tb, decimal min, decimal max)
        {
            decimal value = Convert.ToDecimal(tb.Text);
            if(value >= min && value <= max)
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " must be within range from " + (int) min + ".." + (int) max, "Input Range Error");
                tb.Focus();
                return false;
            }
        }
    }
}
