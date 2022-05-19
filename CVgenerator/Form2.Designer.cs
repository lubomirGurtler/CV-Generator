namespace CVgenerator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.NextButton2 = new System.Windows.Forms.Button();
            this.BackButton1 = new System.Windows.Forms.Button();
            this.job_title_label = new System.Windows.Forms.Label();
            this.employer_label = new System.Windows.Forms.Label();
            this.city_town_label = new System.Windows.Forms.Label();
            this.jobtitle_textBox = new System.Windows.Forms.TextBox();
            this.employer_textBox = new System.Windows.Forms.TextBox();
            this.citytown_textBox = new System.Windows.Forms.TextBox();
            this.end_month_label = new System.Windows.Forms.Label();
            this.end_month_comboBox = new System.Windows.Forms.ComboBox();
            this.end_year_comboBox = new System.Windows.Forms.ComboBox();
            this.start_month_comboBox = new System.Windows.Forms.ComboBox();
            this.start_year_comboBox = new System.Windows.Forms.ComboBox();
            this.start_month_label = new System.Windows.Forms.Label();
            this.plus_button = new System.Windows.Forms.Button();
            this.workLabel = new System.Windows.Forms.Label();
            this.start_year_label = new System.Windows.Forms.Label();
            this.end_year_label = new System.Windows.Forms.Label();
            this.employmentdataGridView = new System.Windows.Forms.DataGridView();
            this.jobtitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citytownColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startmonthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startyearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endmonthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endyearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.employmentdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NextButton2
            // 
            this.NextButton2.Location = new System.Drawing.Point(450, 300);
            this.NextButton2.Name = "NextButton2";
            this.NextButton2.Size = new System.Drawing.Size(100, 30);
            this.NextButton2.TabIndex = 10;
            this.NextButton2.Text = "Next";
            this.NextButton2.UseVisualStyleBackColor = true;
            this.NextButton2.Click += new System.EventHandler(this.NextButton2_Click);
            // 
            // BackButton1
            // 
            this.BackButton1.Location = new System.Drawing.Point(325, 300);
            this.BackButton1.Name = "BackButton1";
            this.BackButton1.Size = new System.Drawing.Size(100, 30);
            this.BackButton1.TabIndex = 9;
            this.BackButton1.Text = "Back";
            this.BackButton1.UseVisualStyleBackColor = true;
            this.BackButton1.Click += new System.EventHandler(this.BackButton1_Click);
            // 
            // job_title_label
            // 
            this.job_title_label.AutoSize = true;
            this.job_title_label.Location = new System.Drawing.Point(36, 31);
            this.job_title_label.Name = "job_title_label";
            this.job_title_label.Size = new System.Drawing.Size(43, 13);
            this.job_title_label.TabIndex = 3;
            this.job_title_label.Text = "Job title";
            // 
            // employer_label
            // 
            this.employer_label.AutoSize = true;
            this.employer_label.Location = new System.Drawing.Point(226, 31);
            this.employer_label.Name = "employer_label";
            this.employer_label.Size = new System.Drawing.Size(50, 13);
            this.employer_label.TabIndex = 4;
            this.employer_label.Text = "Employer";
            // 
            // city_town_label
            // 
            this.city_town_label.AutoSize = true;
            this.city_town_label.Location = new System.Drawing.Point(419, 31);
            this.city_town_label.Name = "city_town_label";
            this.city_town_label.Size = new System.Drawing.Size(56, 13);
            this.city_town_label.TabIndex = 5;
            this.city_town_label.Text = "City/Town";
            // 
            // jobtitle_textBox
            // 
            this.jobtitle_textBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.jobtitle_textBox.Location = new System.Drawing.Point(39, 47);
            this.jobtitle_textBox.MaxLength = 50;
            this.jobtitle_textBox.Name = "jobtitle_textBox";
            this.jobtitle_textBox.Size = new System.Drawing.Size(176, 20);
            this.jobtitle_textBox.TabIndex = 0;
            this.jobtitle_textBox.Tag = "e.g. programmer";
            this.jobtitle_textBox.Text = "e.g. programmer";
            this.jobtitle_textBox.Enter += new System.EventHandler(this.jobtitle_textBox_Enter);
            this.jobtitle_textBox.Leave += new System.EventHandler(this.jobtitle_textBox_Leave);
            // 
            // employer_textBox
            // 
            this.employer_textBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.employer_textBox.Location = new System.Drawing.Point(229, 47);
            this.employer_textBox.MaxLength = 50;
            this.employer_textBox.Name = "employer_textBox";
            this.employer_textBox.Size = new System.Drawing.Size(175, 20);
            this.employer_textBox.TabIndex = 1;
            this.employer_textBox.Tag = "e.g. Google Corp.";
            this.employer_textBox.Text = "e.g. Google Corp.";
            this.employer_textBox.Enter += new System.EventHandler(this.employer_textBox_Enter);
            this.employer_textBox.Leave += new System.EventHandler(this.employer_textBox_Leave);
            // 
            // citytown_textBox
            // 
            this.citytown_textBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.citytown_textBox.Location = new System.Drawing.Point(422, 47);
            this.citytown_textBox.MaxLength = 30;
            this.citytown_textBox.Name = "citytown_textBox";
            this.citytown_textBox.Size = new System.Drawing.Size(128, 20);
            this.citytown_textBox.TabIndex = 2;
            this.citytown_textBox.Tag = "e.g. Los Angeles";
            this.citytown_textBox.Text = "e.g. Los Angeles";
            this.citytown_textBox.Enter += new System.EventHandler(this.citytown_textBox_Enter);
            this.citytown_textBox.Leave += new System.EventHandler(this.citytown_textBox_Leave);
            // 
            // end_month_label
            // 
            this.end_month_label.AutoSize = true;
            this.end_month_label.Location = new System.Drawing.Point(289, 79);
            this.end_month_label.Name = "end_month_label";
            this.end_month_label.Size = new System.Drawing.Size(58, 13);
            this.end_month_label.TabIndex = 9;
            this.end_month_label.Text = "End month";
            // 
            // end_month_comboBox
            // 
            this.end_month_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.end_month_comboBox.FormattingEnabled = true;
            this.end_month_comboBox.Location = new System.Drawing.Point(292, 95);
            this.end_month_comboBox.Name = "end_month_comboBox";
            this.end_month_comboBox.Size = new System.Drawing.Size(95, 21);
            this.end_month_comboBox.TabIndex = 5;
            // 
            // end_year_comboBox
            // 
            this.end_year_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.end_year_comboBox.FormattingEnabled = true;
            this.end_year_comboBox.Location = new System.Drawing.Point(393, 95);
            this.end_year_comboBox.Name = "end_year_comboBox";
            this.end_year_comboBox.Size = new System.Drawing.Size(95, 21);
            this.end_year_comboBox.TabIndex = 6;
            // 
            // start_month_comboBox
            // 
            this.start_month_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.start_month_comboBox.FormattingEnabled = true;
            this.start_month_comboBox.Location = new System.Drawing.Point(39, 95);
            this.start_month_comboBox.Name = "start_month_comboBox";
            this.start_month_comboBox.Size = new System.Drawing.Size(95, 21);
            this.start_month_comboBox.TabIndex = 3;
            // 
            // start_year_comboBox
            // 
            this.start_year_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.start_year_comboBox.FormattingEnabled = true;
            this.start_year_comboBox.Location = new System.Drawing.Point(140, 95);
            this.start_year_comboBox.Name = "start_year_comboBox";
            this.start_year_comboBox.Size = new System.Drawing.Size(95, 21);
            this.start_year_comboBox.TabIndex = 4;
            // 
            // start_month_label
            // 
            this.start_month_label.AutoSize = true;
            this.start_month_label.Location = new System.Drawing.Point(36, 80);
            this.start_month_label.Name = "start_month_label";
            this.start_month_label.Size = new System.Drawing.Size(61, 13);
            this.start_month_label.TabIndex = 14;
            this.start_month_label.Text = "Start month";
            // 
            // plus_button
            // 
            this.plus_button.BackColor = System.Drawing.SystemColors.Control;
            this.plus_button.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plus_button.ForeColor = System.Drawing.Color.Black;
            this.plus_button.Location = new System.Drawing.Point(510, 76);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(40, 40);
            this.plus_button.TabIndex = 7;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = false;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workLabel.Location = new System.Drawing.Point(36, 9);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(133, 16);
            this.workLabel.TabIndex = 16;
            this.workLabel.Text = "Work experiences";
            // 
            // start_year_label
            // 
            this.start_year_label.AutoSize = true;
            this.start_year_label.Location = new System.Drawing.Point(137, 80);
            this.start_year_label.Name = "start_year_label";
            this.start_year_label.Size = new System.Drawing.Size(52, 13);
            this.start_year_label.TabIndex = 17;
            this.start_year_label.Text = "Start year";
            // 
            // end_year_label
            // 
            this.end_year_label.AutoSize = true;
            this.end_year_label.Location = new System.Drawing.Point(390, 79);
            this.end_year_label.Name = "end_year_label";
            this.end_year_label.Size = new System.Drawing.Size(49, 13);
            this.end_year_label.TabIndex = 18;
            this.end_year_label.Text = "End year";
            // 
            // employmentdataGridView
            // 
            this.employmentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employmentdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobtitleColumn,
            this.employerColumn,
            this.citytownColumn,
            this.startmonthColumn,
            this.startyearColumn,
            this.endmonthColumn,
            this.endyearColumn});
            this.employmentdataGridView.Location = new System.Drawing.Point(39, 122);
            this.employmentdataGridView.MultiSelect = false;
            this.employmentdataGridView.Name = "employmentdataGridView";
            this.employmentdataGridView.ReadOnly = true;
            this.employmentdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employmentdataGridView.Size = new System.Drawing.Size(511, 163);
            this.employmentdataGridView.TabIndex = 8;
            // 
            // jobtitleColumn
            // 
            this.jobtitleColumn.DataPropertyName = "JobTitle";
            this.jobtitleColumn.HeaderText = "Job title";
            this.jobtitleColumn.Name = "jobtitleColumn";
            this.jobtitleColumn.ReadOnly = true;
            this.jobtitleColumn.Width = 98;
            // 
            // employerColumn
            // 
            this.employerColumn.DataPropertyName = "Employer";
            this.employerColumn.HeaderText = "Employer";
            this.employerColumn.Name = "employerColumn";
            this.employerColumn.ReadOnly = true;
            this.employerColumn.Width = 95;
            // 
            // citytownColumn
            // 
            this.citytownColumn.DataPropertyName = "City";
            this.citytownColumn.HeaderText = "City/Town";
            this.citytownColumn.Name = "citytownColumn";
            this.citytownColumn.ReadOnly = true;
            this.citytownColumn.Width = 75;
            // 
            // startmonthColumn
            // 
            this.startmonthColumn.DataPropertyName = "StartMonth";
            this.startmonthColumn.HeaderText = "Start month";
            this.startmonthColumn.Name = "startmonthColumn";
            this.startmonthColumn.ReadOnly = true;
            this.startmonthColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.startmonthColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.startmonthColumn.Width = 50;
            // 
            // startyearColumn
            // 
            this.startyearColumn.DataPropertyName = "StartYear";
            this.startyearColumn.HeaderText = "Start year";
            this.startyearColumn.Name = "startyearColumn";
            this.startyearColumn.ReadOnly = true;
            this.startyearColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.startyearColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.startyearColumn.Width = 50;
            // 
            // endmonthColumn
            // 
            this.endmonthColumn.DataPropertyName = "EndMonth";
            this.endmonthColumn.HeaderText = "End month";
            this.endmonthColumn.Name = "endmonthColumn";
            this.endmonthColumn.ReadOnly = true;
            this.endmonthColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.endmonthColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.endmonthColumn.Width = 50;
            // 
            // endyearColumn
            // 
            this.endyearColumn.DataPropertyName = "EndYear";
            this.endyearColumn.HeaderText = "End year";
            this.endyearColumn.Name = "endyearColumn";
            this.endyearColumn.ReadOnly = true;
            this.endyearColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.endyearColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.endyearColumn.Width = 50;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.infoLabel.Location = new System.Drawing.Point(39, 316);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(32, 16);
            this.infoLabel.TabIndex = 19;
            this.infoLabel.Text = "info";
            this.toolTip.SetToolTip(this.infoLabel, "Your items will be ordered automatically by date from newest to oldest.");
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 15000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Info";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.employmentdataGridView);
            this.Controls.Add(this.end_year_label);
            this.Controls.Add(this.start_year_label);
            this.Controls.Add(this.workLabel);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.start_month_label);
            this.Controls.Add(this.start_year_comboBox);
            this.Controls.Add(this.start_month_comboBox);
            this.Controls.Add(this.end_year_comboBox);
            this.Controls.Add(this.end_month_comboBox);
            this.Controls.Add(this.end_month_label);
            this.Controls.Add(this.citytown_textBox);
            this.Controls.Add(this.employer_textBox);
            this.Controls.Add(this.jobtitle_textBox);
            this.Controls.Add(this.city_town_label);
            this.Controls.Add(this.employer_label);
            this.Controls.Add(this.job_title_label);
            this.Controls.Add(this.BackButton1);
            this.Controls.Add(this.NextButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV Maker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.employmentdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton2;
        private System.Windows.Forms.Button BackButton1;
        private System.Windows.Forms.Label job_title_label;
        private System.Windows.Forms.Label employer_label;
        private System.Windows.Forms.Label city_town_label;
        private System.Windows.Forms.TextBox jobtitle_textBox;
        private System.Windows.Forms.TextBox employer_textBox;
        private System.Windows.Forms.TextBox citytown_textBox;
        private System.Windows.Forms.Label end_month_label;
        private System.Windows.Forms.ComboBox end_month_comboBox;
        private System.Windows.Forms.ComboBox end_year_comboBox;
        private System.Windows.Forms.ComboBox start_month_comboBox;
        private System.Windows.Forms.ComboBox start_year_comboBox;
        private System.Windows.Forms.Label start_month_label;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Label workLabel;
        private System.Windows.Forms.Label start_year_label;
        private System.Windows.Forms.Label end_year_label;
        private System.Windows.Forms.DataGridView employmentdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citytownColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startmonthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startyearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endmonthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endyearColumn;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ToolTip toolTip;
    }
}