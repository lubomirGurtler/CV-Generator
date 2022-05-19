using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVgenerator
{
    public partial class Form3 : Form
    {
        EducationManager educationManager = new EducationManager();

        SkillManager skillManager = new SkillManager();
        
        public static string interests;
        
        public static List<char> driverLicence = new List<char>();

        char[] charLicence = { 'B', 'C', 'D', 'E', 'T' };

        public void GetLicence()
        {
            bool[] licences = { BcheckBox.Checked, CcheckBox.Checked, DcheckBox.Checked, EcheckBox.Checked, TcheckBox.Checked };
            int i = 0;
            foreach (bool licence in licences)
            {
                if (licence)
                {
                    driverLicence.Add(charLicence[i]);
                }
                i++;
            }
        }

        public static List<string> education = new List<string>();
       
        public static List<string> skills = new List<string>();

        public Form3()
        {
            InitializeComponent();
            educationDataGridView.AutoGenerateColumns = false;
            educationDataGridView.DataSource = educationManager.educationList;
            skillsdataGridView.AutoGenerateColumns = false;
            skillsdataGridView.DataSource = skillManager.skills;
            Auxiliary.Years(startyearCombobox);
            Auxiliary.Years(endyearCombobox);
            startyearCombobox.SelectedIndex = 0;
            endyearCombobox.SelectedIndex = 0;
            levelComboBox.SelectedIndex = 0;
            startyearCombobox.Select();            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton2_Click(object sender, EventArgs e)
        {
            Hide();
            Owner.Show();            
        }

        private void plusEducationButton_Click(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(degreeTextbox);
            Auxiliary.EnterBox(schoolTextbox);
            Auxiliary.EnterBox(citytownTextbox);
            if (degreeTextbox.Text == "" || schoolTextbox.Text == "" || citytownTextbox.Text == "" || startyearCombobox.SelectedIndex == 0 || endyearCombobox.SelectedIndex == 0)
                MessageBox.Show("All fields in section \"Education/Qualification\" must be filled or chosen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    Education education = new Education(degreeTextbox.Text, schoolTextbox.Text, citytownTextbox.Text, startyearCombobox.Text, endyearCombobox.Text);
                    educationManager.AddEducation(education);
                    Auxiliary.EmptyTextBox(degreeTextbox, schoolTextbox, citytownTextbox);
                    Auxiliary.EmptyComboBox(startyearCombobox, endyearCombobox);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Auxiliary.SetTextToTextBox(degreeTextbox);
            Auxiliary.SetTextToTextBox(schoolTextbox);
            Auxiliary.SetTextToTextBox(citytownTextbox);
        }

        private void plusSkillButton_Click(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(skillTextbox);
            if (skillTextbox.Text == "" || levelComboBox.SelectedIndex == 0)
                MessageBox.Show("All fields in section \"Skills\" must be filled or chosen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Skill skill = new Skill(skillTextbox.Text, levelComboBox.Text, levelComboBox.SelectedIndex);
                skillManager.AddSkill(skill);
                Auxiliary.EmptyTextBox(skillTextbox);
                Auxiliary.EmptyComboBox(levelComboBox);
            }
            Auxiliary.SetTextToTextBox(skillTextbox);
        }

        private void degreeTextbox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(degreeTextbox);
        }

        private void degreeTextbox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(degreeTextbox);
        }

        private void schoolTextbox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(schoolTextbox);
        }

        private void schoolTextbox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(schoolTextbox);
        }

        private void citytownTextbox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(citytownTextbox);
        }

        private void citytownTextbox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(citytownTextbox);
        }

        private void skillTextbox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(skillTextbox);
        }

        private void skillTextbox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(skillTextbox);
        }

        private void interestsTextbox_Enter(object sender, EventArgs e)
        {
            Auxiliary.EnterBox(interestsTextbox);
        }

        private void interestsTextbox_Leave(object sender, EventArgs e)
        {
            Auxiliary.LeaveBox(interestsTextbox);
        }

        private void MakeitButton_Click(object sender, EventArgs e)
        {
            GetLicence();
            education = educationManager.GetEducationList();
            skills = skillManager.GetSkills();
            interests = interestsTextbox.Text;
            Auxiliary.StringToEmpty(ref interests);
            try
            {
                ExportFile.MakePDF();
                MessageBox.Show("Your CV has been created on your desktop as CV.pdf", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "A file CV.pdf is open, please close the file..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
