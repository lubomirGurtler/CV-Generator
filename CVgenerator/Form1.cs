using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace CVgenerator
{
    public partial class Form1 : Form
    {
        Form2 f2;        

        public static string name;
        
        public static string surname;
        
        public static string address;
        
        public static string zipcode;
        
        public static string city;
        
        public static string email;
        
        public static string phone;
        
        public static string placeofbirth;
        
        public static string dateofbirth = "";
        
        public static string nationality;
        
        public static string marital;

        public static string link;

        public static string file = "";
        
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
            Auxiliary.Nationalities(nationComboBox);
            nationComboBox.SelectedIndex = 0;
            maritalComboBox.SelectedIndex = 0;
            nationComboBox.Select();            
        }        

        private void NextButton1_Click(object sender, EventArgs e)
        {            
            name = nameBox.Text;
            surname = surnameBox.Text;
            address = addressBox.Text;
            zipcode = zipcodeBox.Text;
            city = cityBox.Text;
            email = emailBox.Text;
            phone = phoneBox.Text;
            placeofbirth = placeofBBox.Text;
            link = linkTextBox.Text;
            if (dateTimePicker.Value.Date != DateTime.Now.Date)
                dateofbirth = dateTimePicker.Value.ToShortDateString();
            nationality = nationComboBox.GetItemText(nationComboBox.SelectedItem);
            marital = maritalComboBox.GetItemText(maritalComboBox.SelectedItem);

            Auxiliary.StringToEmpty(ref name);
            Auxiliary.StringToEmpty(ref surname);
            Auxiliary.StringToEmpty(ref address);
            Auxiliary.StringToEmpty(ref zipcode);
            Auxiliary.StringToEmpty(ref city);
            Auxiliary.StringToEmpty(ref email);
            Auxiliary.StringToEmpty(ref phone);
            Auxiliary.StringToEmpty(ref placeofbirth);
            Auxiliary.StringToEmpty(ref nationality);
            Auxiliary.StringToEmpty(ref marital);
            Auxiliary.StringToEmpty(ref link);

            bool next = true;
            bool[] valid = new bool[3];
            valid[0] = Auxiliary.CheckEmail(email);
            valid[1] = Auxiliary.CheckPhone(phone);
            valid[2] = Auxiliary.CheckZipcode(zipcode);
            foreach (bool x in valid)
            {
                if (!x)
                {
                    next = false;
                }
            }
            if (next)
            {
                Hide();
                f2.Show(this);
            }
        }

        private void PhoneBox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(phoneBox);            
        }

        private void PhoneBox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(phoneBox);            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NameBox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(nameBox);
        }

        private void NameBox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(nameBox);
        }

        private void SurnameBox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(surnameBox);
        }

        private void SurnameBox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(surnameBox);
        }

        private void AddressBox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(addressBox);
        }

        private void AddressBox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(addressBox);
        }

        private void ZipcodeBox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(zipcodeBox);
        }

        private void ZipcodeBox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(zipcodeBox);
        }

        private void CityBox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(cityBox);
        }

        private void CityBox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(cityBox);
        }

        private void EmailBox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(emailBox);
        }

        private void EmailBox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(emailBox);
        }

        private void PlaceofBBox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(placeofBBox);
        }

        private void PlaceofBBox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(placeofBBox);
        }

        private void linkTextBox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(linkTextBox);
        }

        private void linkTextBox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(linkTextBox);
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPG File (*.jpg)|*.jpg";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ShowDialog();
            file = openFileDialog.FileName;            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (file != "")
            {
                Pen pen = new Pen(Color.Green, 3);
                e.Graphics.DrawLine(pen, 370, 55, 377, 62);
                e.Graphics.DrawLine(pen, 376, 61, 386, 51);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Invalidate();
        }
    }
}
