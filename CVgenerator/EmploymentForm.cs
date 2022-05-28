using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVgenerator
{
    public partial class EmploymentForm : Form
    {
        EmploymentManager employmentManager = new EmploymentManager();

        public static List<string> employments = new List<string>();        

        EducationForm f3;

        public EmploymentForm()
        {
            InitializeComponent();            
            f3 = new EducationForm();
            employmentdataGridView.AutoGenerateColumns = false;
            employmentdataGridView.DataSource = employmentManager.employmentsList;            
            Auxiliary.Years(start_year_comboBox);
            Auxiliary.Years(end_year_comboBox);
            Auxiliary.Months(start_month_comboBox);
            Auxiliary.Months(end_month_comboBox);
            start_month_comboBox.SelectedIndex = 0;
            start_year_comboBox.SelectedIndex = 0;
            end_month_comboBox.SelectedIndex = 0;
            end_year_comboBox.SelectedIndex = 0;
            start_month_comboBox.Select();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton1_Click(object sender, EventArgs e)
        {
            Hide();
            Owner.Show();
        }

        private void NextButton2_Click(object sender, EventArgs e)
        {
            Hide();
            f3.Show(this);            
            employments = employmentManager.GetEmployments();
        }       

        private void plus_button_Click(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(jobtitle_textBox);
            Auxiliary.EnterBox(employer_textBox);
            Auxiliary.EnterBox(citytown_textBox);
            if (jobtitle_textBox.Text == "" || employer_textBox.Text == "" || citytown_textBox.Text == "" || start_month_comboBox.SelectedIndex == 0 || start_year_comboBox.SelectedIndex == 0 || end_month_comboBox.SelectedIndex == 0 || end_year_comboBox.SelectedIndex == 0)
                MessageBox.Show("All fields must be filled or chosen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    Employment employment = new Employment(jobtitle_textBox.Text, employer_textBox.Text, citytown_textBox.Text, start_month_comboBox.Text, end_month_comboBox.Text, start_year_comboBox.Text, end_year_comboBox.Text);
                    employmentManager.AddEmployment(employment);
                    Auxiliary.EmptyTextBox(jobtitle_textBox, employer_textBox, citytown_textBox);
                    Auxiliary.EmptyComboBox(start_month_comboBox, end_month_comboBox, start_year_comboBox, end_year_comboBox);                    
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
            Auxiliary.SetTextToTextBox(jobtitle_textBox);
            Auxiliary.SetTextToTextBox(employer_textBox);
            Auxiliary.SetTextToTextBox(citytown_textBox);            
        }

        private void jobtitle_textBox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(jobtitle_textBox);
        }

        private void jobtitle_textBox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(jobtitle_textBox);
        }

        private void employer_textBox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(employer_textBox);
        }

        private void employer_textBox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(employer_textBox);
        }

        private void citytown_textBox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(citytown_textBox);
        }

        private void citytown_textBox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(citytown_textBox);
        }
    }
}
