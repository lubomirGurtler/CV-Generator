using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Drawing;
using System.Text.RegularExpressions;
using CVgenerator.Properties;

namespace CVgenerator
{
    public class Auxiliary
    {
        //adds collection of years to combobox
        public static void Years(ComboBox combo)
        {
            List<int> years = new List<int>();
            for (int i = 1960; i <= DateTime.Today.Year; i++)
            {
                years.Add(i);
            }
            years.Reverse();
            foreach (int x in years)
            {
                combo.Items.Add(x);
            }
            combo.Items.Insert(0, "-- select --");
        }

        //adds collection of months to combobox
        public static void Months(ComboBox combo)
        {            
            for (int i = 0; i < 12; i++)
            {
                DateTime date = new DateTime(2000, i + 1, 1);
                combo.Items.Add(date.ToString("MMMM", new CultureInfo("en-US")));
            }
            combo.Items.Insert(0, "-- select --");
        }

        //adds nationalities to combobox from resources
        public static void Nationalities(ComboBox combo)
        {
            string[] nations = Resources.Nationalities.Split('\n');
            foreach (string nation in nations)
            {
                combo.Items.Add(nation);
            }
            combo.Items.Insert(0, "-- select --");
        }

        //set input textboxes to empty string
        public static void EmptyTextBox(params TextBox[] texts)
        {
            foreach (var text in texts) text.Text = "";
        }

        //set input comboboxes to empty string
        public static void EmptyComboBox(params ComboBox[] texts)
        {
            foreach (var text in texts) text.SelectedIndex = 0;
        }

        //click on textbox sets it to empty string
        public static void EnterBox(TextBox text)
        {
            if (text.Text == text.Tag.ToString())
            {
                text.Text = "";
                text.ForeColor = System.Drawing.Color.Black;
            }
        }

        //click to another textbox this textbox going to set help text
        public static void LeaveBox(TextBox text)
        {
            if (text.Text == "")
            {
                text.Text = text.Tag.ToString();
                text.ForeColor = System.Drawing.SystemColors.ControlDark;
            }
        }

        //if is textbox empty inserts help text
        public static void SetTextToTextBox(TextBox text)
        {
            if (text.Text == "")
            {
                text.Text = text.Tag.ToString();
                text.ForeColor = System.Drawing.SystemColors.ControlDark;
            }
        }

        //it avoids to set help text to variables
        public static void StringToEmpty(ref string s)
        {            
            if (s.Contains("e.g.") || s.Contains("-- select --"))
                s = "";                        
        }

        //gets value of month
        public static int GetMonthValue(string month)
        {
            int result = 0;
            for (int i = 0; i < 12; i++)
            {
                DateTime date = new DateTime(2000, i + 1, 1);
                result++;
                if (month == date.ToString("MMMM", new CultureInfo("en-US")))
                    break;
            }
            return result;
        }

        //validates email address
        public static bool CheckEmail(string email)
        {
            string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            bool match = Regex.IsMatch(email, pattern);
            if (!match && email != "") MessageBox.Show("That is not a email address! Please enter correct email address..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (email == "") match = true;
            return match;
        }

        //validates phone number
        public static bool CheckPhone(string phone)
        {
            string pattern = @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$";
            bool match = Regex.IsMatch(phone, pattern);
            if (!match && phone != "") MessageBox.Show("That is not a phone number! Please enter correct phone number..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (phone == "") match = true;
            return match;
        }

        //validates zipcode
        public static bool CheckZipcode(string zip)
        {
            string pattern = @"^\d{3}\s?\d{2}(?:[-\s]\d{4})?$";
            bool match = Regex.IsMatch(zip, pattern);
            if (!match && zip != "") MessageBox.Show("That is not a ZIP code! Please enter correct ZIP code..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (zip == "") match = true;
            return match;
        }
    }
}
