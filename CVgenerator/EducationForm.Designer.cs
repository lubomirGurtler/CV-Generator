namespace CVgenerator
{
    partial class EducationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationForm));
            this.MakeitButton = new System.Windows.Forms.Button();
            this.BackButton2 = new System.Windows.Forms.Button();
            this.degreeTextbox = new System.Windows.Forms.TextBox();
            this.degreeLabel = new System.Windows.Forms.Label();
            this.schoolTextbox = new System.Windows.Forms.TextBox();
            this.schoolLabel = new System.Windows.Forms.Label();
            this.citytownTextbox = new System.Windows.Forms.TextBox();
            this.citytownLabel = new System.Windows.Forms.Label();
            this.startyearCombobox = new System.Windows.Forms.ComboBox();
            this.endyearCombobox = new System.Windows.Forms.ComboBox();
            this.startyearLabel = new System.Windows.Forms.Label();
            this.endyearLabel = new System.Windows.Forms.Label();
            this.plusEducationButton = new System.Windows.Forms.Button();
            this.educationLabel = new System.Windows.Forms.Label();
            this.skillsLabel = new System.Windows.Forms.Label();
            this.skillLabel = new System.Windows.Forms.Label();
            this.skillTextbox = new System.Windows.Forms.TextBox();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.plusSkillButton = new System.Windows.Forms.Button();
            this.driverLabel = new System.Windows.Forms.Label();
            this.BcheckBox = new System.Windows.Forms.CheckBox();
            this.DcheckBox = new System.Windows.Forms.CheckBox();
            this.CcheckBox = new System.Windows.Forms.CheckBox();
            this.EcheckBox = new System.Windows.Forms.CheckBox();
            this.TcheckBox = new System.Windows.Forms.CheckBox();
            this.InterestsLabel = new System.Windows.Forms.Label();
            this.interestsTextbox = new System.Windows.Forms.TextBox();
            this.skillsdataGridView = new System.Windows.Forms.DataGridView();
            this.skillColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridView = new System.Windows.Forms.DataGridView();
            this.degreeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startyearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endyearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skillsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MakeitButton
            // 
            this.MakeitButton.Location = new System.Drawing.Point(450, 300);
            this.MakeitButton.Name = "MakeitButton";
            this.MakeitButton.Size = new System.Drawing.Size(100, 30);
            this.MakeitButton.TabIndex = 18;
            this.MakeitButton.Text = "Make it!";
            this.MakeitButton.UseVisualStyleBackColor = true;
            this.MakeitButton.Click += new System.EventHandler(this.MakeitButton_Click);
            // 
            // BackButton2
            // 
            this.BackButton2.Location = new System.Drawing.Point(325, 300);
            this.BackButton2.Name = "BackButton2";
            this.BackButton2.Size = new System.Drawing.Size(100, 30);
            this.BackButton2.TabIndex = 17;
            this.BackButton2.Text = "Back";
            this.BackButton2.UseVisualStyleBackColor = true;
            this.BackButton2.Click += new System.EventHandler(this.BackButton2_Click);
            // 
            // degreeTextbox
            // 
            this.degreeTextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.degreeTextbox.Location = new System.Drawing.Point(39, 47);
            this.degreeTextbox.MaxLength = 50;
            this.degreeTextbox.Name = "degreeTextbox";
            this.degreeTextbox.Size = new System.Drawing.Size(173, 20);
            this.degreeTextbox.TabIndex = 0;
            this.degreeTextbox.Tag = "e.g. Bachelor of computer science";
            this.degreeTextbox.Text = "e.g. Bachelor of computer science";
            this.degreeTextbox.Enter += new System.EventHandler(this.degreeTextbox_Enter);
            this.degreeTextbox.Leave += new System.EventHandler(this.degreeTextbox_Leave);
            // 
            // degreeLabel
            // 
            this.degreeLabel.AutoSize = true;
            this.degreeLabel.Location = new System.Drawing.Point(36, 31);
            this.degreeLabel.Name = "degreeLabel";
            this.degreeLabel.Size = new System.Drawing.Size(105, 13);
            this.degreeLabel.TabIndex = 3;
            this.degreeLabel.Text = "Degree/Qualification";
            // 
            // schoolTextbox
            // 
            this.schoolTextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.schoolTextbox.Location = new System.Drawing.Point(39, 88);
            this.schoolTextbox.MaxLength = 50;
            this.schoolTextbox.Name = "schoolTextbox";
            this.schoolTextbox.Size = new System.Drawing.Size(173, 20);
            this.schoolTextbox.TabIndex = 1;
            this.schoolTextbox.Tag = "e.g. Harvard University";
            this.schoolTextbox.Text = "e.g. Harvard University";
            this.schoolTextbox.Enter += new System.EventHandler(this.schoolTextbox_Enter);
            this.schoolTextbox.Leave += new System.EventHandler(this.schoolTextbox_Leave);
            // 
            // schoolLabel
            // 
            this.schoolLabel.AutoSize = true;
            this.schoolLabel.Location = new System.Drawing.Point(36, 72);
            this.schoolLabel.Name = "schoolLabel";
            this.schoolLabel.Size = new System.Drawing.Size(40, 13);
            this.schoolLabel.TabIndex = 5;
            this.schoolLabel.Text = "School";
            // 
            // citytownTextbox
            // 
            this.citytownTextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.citytownTextbox.Location = new System.Drawing.Point(39, 130);
            this.citytownTextbox.MaxLength = 30;
            this.citytownTextbox.Name = "citytownTextbox";
            this.citytownTextbox.Size = new System.Drawing.Size(144, 20);
            this.citytownTextbox.TabIndex = 2;
            this.citytownTextbox.Tag = "e.g. Cambridge";
            this.citytownTextbox.Text = "e.g. Cambridge";
            this.citytownTextbox.Enter += new System.EventHandler(this.citytownTextbox_Enter);
            this.citytownTextbox.Leave += new System.EventHandler(this.citytownTextbox_Leave);
            // 
            // citytownLabel
            // 
            this.citytownLabel.AutoSize = true;
            this.citytownLabel.Location = new System.Drawing.Point(36, 114);
            this.citytownLabel.Name = "citytownLabel";
            this.citytownLabel.Size = new System.Drawing.Size(56, 13);
            this.citytownLabel.TabIndex = 7;
            this.citytownLabel.Text = "City/Town";
            // 
            // startyearCombobox
            // 
            this.startyearCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startyearCombobox.FormattingEnabled = true;
            this.startyearCombobox.Location = new System.Drawing.Point(225, 46);
            this.startyearCombobox.Name = "startyearCombobox";
            this.startyearCombobox.Size = new System.Drawing.Size(74, 21);
            this.startyearCombobox.TabIndex = 3;
            // 
            // endyearCombobox
            // 
            this.endyearCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endyearCombobox.FormattingEnabled = true;
            this.endyearCombobox.Location = new System.Drawing.Point(225, 87);
            this.endyearCombobox.Name = "endyearCombobox";
            this.endyearCombobox.Size = new System.Drawing.Size(74, 21);
            this.endyearCombobox.TabIndex = 4;
            this.endyearCombobox.Tag = "";
            // 
            // startyearLabel
            // 
            this.startyearLabel.AutoSize = true;
            this.startyearLabel.Location = new System.Drawing.Point(222, 30);
            this.startyearLabel.Name = "startyearLabel";
            this.startyearLabel.Size = new System.Drawing.Size(52, 13);
            this.startyearLabel.TabIndex = 10;
            this.startyearLabel.Text = "Start year";
            // 
            // endyearLabel
            // 
            this.endyearLabel.AutoSize = true;
            this.endyearLabel.Location = new System.Drawing.Point(222, 70);
            this.endyearLabel.Name = "endyearLabel";
            this.endyearLabel.Size = new System.Drawing.Size(49, 13);
            this.endyearLabel.TabIndex = 11;
            this.endyearLabel.Text = "End year";
            // 
            // plusEducationButton
            // 
            this.plusEducationButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusEducationButton.Location = new System.Drawing.Point(259, 127);
            this.plusEducationButton.Name = "plusEducationButton";
            this.plusEducationButton.Size = new System.Drawing.Size(40, 40);
            this.plusEducationButton.TabIndex = 5;
            this.plusEducationButton.Text = "+";
            this.plusEducationButton.UseVisualStyleBackColor = true;
            this.plusEducationButton.Click += new System.EventHandler(this.plusEducationButton_Click);
            // 
            // educationLabel
            // 
            this.educationLabel.AutoSize = true;
            this.educationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.educationLabel.Location = new System.Drawing.Point(36, 9);
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(168, 16);
            this.educationLabel.TabIndex = 14;
            this.educationLabel.Text = "Education/Qualification";
            // 
            // skillsLabel
            // 
            this.skillsLabel.AutoSize = true;
            this.skillsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skillsLabel.Location = new System.Drawing.Point(322, 9);
            this.skillsLabel.Name = "skillsLabel";
            this.skillsLabel.Size = new System.Drawing.Size(46, 16);
            this.skillsLabel.TabIndex = 15;
            this.skillsLabel.Text = "Skills";
            // 
            // skillLabel
            // 
            this.skillLabel.AutoSize = true;
            this.skillLabel.Location = new System.Drawing.Point(322, 31);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(26, 13);
            this.skillLabel.TabIndex = 16;
            this.skillLabel.Text = "Skill";
            // 
            // skillTextbox
            // 
            this.skillTextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.skillTextbox.Location = new System.Drawing.Point(325, 48);
            this.skillTextbox.MaxLength = 30;
            this.skillTextbox.Name = "skillTextbox";
            this.skillTextbox.Size = new System.Drawing.Size(119, 20);
            this.skillTextbox.TabIndex = 7;
            this.skillTextbox.Tag = "e.g. English language";
            this.skillTextbox.Text = "e.g. English language";
            this.skillTextbox.Enter += new System.EventHandler(this.skillTextbox_Enter);
            this.skillTextbox.Leave += new System.EventHandler(this.skillTextbox_Leave);
            // 
            // levelComboBox
            // 
            this.levelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Items.AddRange(new object[] {
            "-- select --",
            "Beginner",
            "Elementary",
            "Intermediate",
            "Upper intermediate",
            "Advanced",
            "Expert"});
            this.levelComboBox.Location = new System.Drawing.Point(465, 47);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(85, 21);
            this.levelComboBox.TabIndex = 8;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(462, 30);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(33, 13);
            this.levelLabel.TabIndex = 19;
            this.levelLabel.Text = "Level";
            // 
            // plusSkillButton
            // 
            this.plusSkillButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusSkillButton.Location = new System.Drawing.Point(325, 76);
            this.plusSkillButton.Name = "plusSkillButton";
            this.plusSkillButton.Size = new System.Drawing.Size(40, 40);
            this.plusSkillButton.TabIndex = 9;
            this.plusSkillButton.Text = "+";
            this.plusSkillButton.UseVisualStyleBackColor = true;
            this.plusSkillButton.Click += new System.EventHandler(this.plusSkillButton_Click);
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.driverLabel.Location = new System.Drawing.Point(322, 183);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(108, 16);
            this.driverLabel.TabIndex = 22;
            this.driverLabel.Text = "Driver Licence";
            // 
            // BcheckBox
            // 
            this.BcheckBox.AutoSize = true;
            this.BcheckBox.Location = new System.Drawing.Point(325, 211);
            this.BcheckBox.Name = "BcheckBox";
            this.BcheckBox.Size = new System.Drawing.Size(33, 17);
            this.BcheckBox.TabIndex = 11;
            this.BcheckBox.Text = "B";
            this.BcheckBox.UseVisualStyleBackColor = true;
            // 
            // DcheckBox
            // 
            this.DcheckBox.AutoSize = true;
            this.DcheckBox.Location = new System.Drawing.Point(403, 211);
            this.DcheckBox.Name = "DcheckBox";
            this.DcheckBox.Size = new System.Drawing.Size(34, 17);
            this.DcheckBox.TabIndex = 13;
            this.DcheckBox.Text = "D";
            this.DcheckBox.UseVisualStyleBackColor = true;
            // 
            // CcheckBox
            // 
            this.CcheckBox.AutoSize = true;
            this.CcheckBox.Location = new System.Drawing.Point(364, 211);
            this.CcheckBox.Name = "CcheckBox";
            this.CcheckBox.Size = new System.Drawing.Size(33, 17);
            this.CcheckBox.TabIndex = 12;
            this.CcheckBox.Text = "C";
            this.CcheckBox.UseVisualStyleBackColor = true;
            // 
            // EcheckBox
            // 
            this.EcheckBox.AutoSize = true;
            this.EcheckBox.Location = new System.Drawing.Point(443, 211);
            this.EcheckBox.Name = "EcheckBox";
            this.EcheckBox.Size = new System.Drawing.Size(33, 17);
            this.EcheckBox.TabIndex = 14;
            this.EcheckBox.Text = "E";
            this.EcheckBox.UseVisualStyleBackColor = true;
            // 
            // TcheckBox
            // 
            this.TcheckBox.AutoSize = true;
            this.TcheckBox.Location = new System.Drawing.Point(482, 211);
            this.TcheckBox.Name = "TcheckBox";
            this.TcheckBox.Size = new System.Drawing.Size(33, 17);
            this.TcheckBox.TabIndex = 15;
            this.TcheckBox.Text = "T";
            this.TcheckBox.UseVisualStyleBackColor = true;
            // 
            // InterestsLabel
            // 
            this.InterestsLabel.AutoSize = true;
            this.InterestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InterestsLabel.Location = new System.Drawing.Point(322, 242);
            this.InterestsLabel.Name = "InterestsLabel";
            this.InterestsLabel.Size = new System.Drawing.Size(67, 16);
            this.InterestsLabel.TabIndex = 28;
            this.InterestsLabel.Text = "Interests";
            // 
            // interestsTextbox
            // 
            this.interestsTextbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.interestsTextbox.Location = new System.Drawing.Point(325, 261);
            this.interestsTextbox.MaxLength = 100;
            this.interestsTextbox.Name = "interestsTextbox";
            this.interestsTextbox.Size = new System.Drawing.Size(225, 20);
            this.interestsTextbox.TabIndex = 16;
            this.interestsTextbox.Tag = "e.g. hiking, swimming etc.";
            this.interestsTextbox.Text = "e.g. hiking, swimming etc.";
            this.interestsTextbox.Enter += new System.EventHandler(this.interestsTextbox_Enter);
            this.interestsTextbox.Leave += new System.EventHandler(this.interestsTextbox_Leave);
            // 
            // skillsdataGridView
            // 
            this.skillsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skillsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skillColumn,
            this.levelColumn});
            this.skillsdataGridView.Location = new System.Drawing.Point(371, 76);
            this.skillsdataGridView.MultiSelect = false;
            this.skillsdataGridView.Name = "skillsdataGridView";
            this.skillsdataGridView.ReadOnly = true;
            this.skillsdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skillsdataGridView.Size = new System.Drawing.Size(179, 91);
            this.skillsdataGridView.TabIndex = 10;
            // 
            // skillColumn
            // 
            this.skillColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.skillColumn.DataPropertyName = "Ability";
            this.skillColumn.HeaderText = "Skill";
            this.skillColumn.Name = "skillColumn";
            this.skillColumn.ReadOnly = true;
            // 
            // levelColumn
            // 
            this.levelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.levelColumn.DataPropertyName = "Level";
            this.levelColumn.HeaderText = "Level";
            this.levelColumn.Name = "levelColumn";
            this.levelColumn.ReadOnly = true;
            // 
            // educationDataGridView
            // 
            this.educationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.educationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.degreeColumn,
            this.schoolColumn,
            this.cityColumn,
            this.startyearColumn,
            this.endyearColumn});
            this.educationDataGridView.Location = new System.Drawing.Point(39, 174);
            this.educationDataGridView.MultiSelect = false;
            this.educationDataGridView.Name = "educationDataGridView";
            this.educationDataGridView.ReadOnly = true;
            this.educationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.educationDataGridView.Size = new System.Drawing.Size(260, 156);
            this.educationDataGridView.TabIndex = 6;
            // 
            // degreeColumn
            // 
            this.degreeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.degreeColumn.DataPropertyName = "Degree";
            this.degreeColumn.FillWeight = 112.3096F;
            this.degreeColumn.HeaderText = "Degree";
            this.degreeColumn.Name = "degreeColumn";
            this.degreeColumn.ReadOnly = true;
            // 
            // schoolColumn
            // 
            this.schoolColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.schoolColumn.DataPropertyName = "School";
            this.schoolColumn.FillWeight = 112.3096F;
            this.schoolColumn.HeaderText = "School";
            this.schoolColumn.Name = "schoolColumn";
            this.schoolColumn.ReadOnly = true;
            // 
            // cityColumn
            // 
            this.cityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityColumn.DataPropertyName = "CityOfSchool";
            this.cityColumn.FillWeight = 112.3096F;
            this.cityColumn.HeaderText = "City";
            this.cityColumn.Name = "cityColumn";
            this.cityColumn.ReadOnly = true;
            // 
            // startyearColumn
            // 
            this.startyearColumn.DataPropertyName = "StartYearEd";
            this.startyearColumn.FillWeight = 112.3096F;
            this.startyearColumn.HeaderText = "Start year";
            this.startyearColumn.Name = "startyearColumn";
            this.startyearColumn.ReadOnly = true;
            this.startyearColumn.Width = 35;
            // 
            // endyearColumn
            // 
            this.endyearColumn.DataPropertyName = "EndYearEd";
            this.endyearColumn.FillWeight = 50.76142F;
            this.endyearColumn.HeaderText = "End year";
            this.endyearColumn.Name = "endyearColumn";
            this.endyearColumn.ReadOnly = true;
            this.endyearColumn.Width = 35;
            // 
            // interestToolTip
            // 
            this.interestToolTip.AutoPopDelay = 15000;
            this.interestToolTip.InitialDelay = 500;
            this.interestToolTip.IsBalloon = true;
            this.interestToolTip.ReshowDelay = 100;
            this.interestToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.interestToolTip.ToolTipTitle = "Info";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.infoLabel.Location = new System.Drawing.Point(518, 232);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(32, 16);
            this.infoLabel.TabIndex = 29;
            this.infoLabel.Text = "info";
            this.interestToolTip.SetToolTip(this.infoLabel, "\"Driver licence\" and \"Interests\" are not necessary. Every single interest please " +
        "separate by \" , \".");
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.educationDataGridView);
            this.Controls.Add(this.skillsdataGridView);
            this.Controls.Add(this.interestsTextbox);
            this.Controls.Add(this.InterestsLabel);
            this.Controls.Add(this.TcheckBox);
            this.Controls.Add(this.EcheckBox);
            this.Controls.Add(this.CcheckBox);
            this.Controls.Add(this.DcheckBox);
            this.Controls.Add(this.BcheckBox);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.plusSkillButton);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.levelComboBox);
            this.Controls.Add(this.skillTextbox);
            this.Controls.Add(this.skillLabel);
            this.Controls.Add(this.skillsLabel);
            this.Controls.Add(this.educationLabel);
            this.Controls.Add(this.plusEducationButton);
            this.Controls.Add(this.endyearLabel);
            this.Controls.Add(this.startyearLabel);
            this.Controls.Add(this.endyearCombobox);
            this.Controls.Add(this.startyearCombobox);
            this.Controls.Add(this.citytownLabel);
            this.Controls.Add(this.citytownTextbox);
            this.Controls.Add(this.schoolLabel);
            this.Controls.Add(this.schoolTextbox);
            this.Controls.Add(this.degreeLabel);
            this.Controls.Add(this.degreeTextbox);
            this.Controls.Add(this.BackButton2);
            this.Controls.Add(this.MakeitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV Maker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.skillsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MakeitButton;
        private System.Windows.Forms.Button BackButton2;
        private System.Windows.Forms.TextBox degreeTextbox;
        private System.Windows.Forms.Label degreeLabel;
        private System.Windows.Forms.TextBox schoolTextbox;
        private System.Windows.Forms.Label schoolLabel;
        private System.Windows.Forms.TextBox citytownTextbox;
        private System.Windows.Forms.Label citytownLabel;
        private System.Windows.Forms.ComboBox startyearCombobox;
        private System.Windows.Forms.ComboBox endyearCombobox;
        private System.Windows.Forms.Label startyearLabel;
        private System.Windows.Forms.Label endyearLabel;
        private System.Windows.Forms.Button plusEducationButton;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.Label skillsLabel;
        private System.Windows.Forms.Label skillLabel;
        private System.Windows.Forms.TextBox skillTextbox;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Button plusSkillButton;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.CheckBox BcheckBox;
        private System.Windows.Forms.CheckBox DcheckBox;
        private System.Windows.Forms.CheckBox CcheckBox;
        private System.Windows.Forms.CheckBox EcheckBox;
        private System.Windows.Forms.CheckBox TcheckBox;
        private System.Windows.Forms.Label InterestsLabel;
        private System.Windows.Forms.TextBox interestsTextbox;
        private System.Windows.Forms.DataGridView skillsdataGridView;
        private System.Windows.Forms.DataGridView educationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startyearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endyearColumn;
        private System.Windows.Forms.ToolTip interestToolTip;
        private System.Windows.Forms.Label infoLabel;
    }
}