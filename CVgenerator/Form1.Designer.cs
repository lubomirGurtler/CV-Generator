namespace CVgenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.ZipcodeLabel = new System.Windows.Forms.Label();
            this.zipcodeBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.DateofBLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PlaceofBLabel = new System.Windows.Forms.Label();
            this.placeofBBox = new System.Windows.Forms.TextBox();
            this.NationLabel = new System.Windows.Forms.Label();
            this.MaritalLabel = new System.Windows.Forms.Label();
            this.maritalComboBox = new System.Windows.Forms.ComboBox();
            this.nationComboBox = new System.Windows.Forms.ComboBox();
            this.NextButton1 = new System.Windows.Forms.Button();
            this.PersonalLabel = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.Label();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.linkTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.nameBox.Location = new System.Drawing.Point(39, 47);
            this.nameBox.MaxLength = 20;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.Tag = "e.g. Sylvester";
            this.nameBox.Text = "e.g. Sylvester";
            this.nameBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.NameBox_Leave);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(36, 31);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(160, 31);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Surname";
            // 
            // surnameBox
            // 
            this.surnameBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.surnameBox.Location = new System.Drawing.Point(163, 47);
            this.surnameBox.MaxLength = 20;
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(100, 20);
            this.surnameBox.TabIndex = 3;
            this.surnameBox.Tag = "e.g. Stallone";
            this.surnameBox.Text = "e.g. Stallone";
            this.surnameBox.Enter += new System.EventHandler(this.SurnameBox_Enter);
            this.surnameBox.Leave += new System.EventHandler(this.SurnameBox_Leave);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(36, 79);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address";
            // 
            // addressBox
            // 
            this.addressBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.addressBox.Location = new System.Drawing.Point(39, 96);
            this.addressBox.MaxLength = 40;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(224, 20);
            this.addressBox.TabIndex = 5;
            this.addressBox.Tag = "e.g. Downing Street 10";
            this.addressBox.Text = "e.g. Downing Street 10";
            this.addressBox.Enter += new System.EventHandler(this.AddressBox_Enter);
            this.addressBox.Leave += new System.EventHandler(this.AddressBox_Leave);
            // 
            // ZipcodeLabel
            // 
            this.ZipcodeLabel.AutoSize = true;
            this.ZipcodeLabel.Location = new System.Drawing.Point(282, 79);
            this.ZipcodeLabel.Name = "ZipcodeLabel";
            this.ZipcodeLabel.Size = new System.Drawing.Size(49, 13);
            this.ZipcodeLabel.TabIndex = 6;
            this.ZipcodeLabel.Text = "Zip code";
            // 
            // zipcodeBox
            // 
            this.zipcodeBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.zipcodeBox.Location = new System.Drawing.Point(285, 95);
            this.zipcodeBox.MaxLength = 10;
            this.zipcodeBox.Name = "zipcodeBox";
            this.zipcodeBox.Size = new System.Drawing.Size(81, 20);
            this.zipcodeBox.TabIndex = 7;
            this.zipcodeBox.Tag = "e.g. 971 01";
            this.zipcodeBox.Text = "e.g. 971 01";
            this.zipcodeBox.Enter += new System.EventHandler(this.ZipcodeBox_Enter);
            this.zipcodeBox.Leave += new System.EventHandler(this.ZipcodeBox_Leave);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(388, 79);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(56, 13);
            this.CityLabel.TabIndex = 8;
            this.CityLabel.Text = "City/Town";
            // 
            // cityBox
            // 
            this.cityBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cityBox.Location = new System.Drawing.Point(391, 95);
            this.cityBox.MaxLength = 20;
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(112, 20);
            this.cityBox.TabIndex = 9;
            this.cityBox.Tag = "e.g. New York";
            this.cityBox.Text = "e.g. New York";
            this.cityBox.Enter += new System.EventHandler(this.CityBox_Enter);
            this.cityBox.Leave += new System.EventHandler(this.CityBox_Leave);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(36, 134);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(72, 13);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "Email address";
            // 
            // emailBox
            // 
            this.emailBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.emailBox.Location = new System.Drawing.Point(39, 150);
            this.emailBox.MaxLength = 40;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(224, 20);
            this.emailBox.TabIndex = 11;
            this.emailBox.Tag = "e.g. example@gmail.com";
            this.emailBox.Text = "e.g. example@gmail.com";
            this.emailBox.Enter += new System.EventHandler(this.EmailBox_Enter);
            this.emailBox.Leave += new System.EventHandler(this.EmailBox_Leave);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(282, 134);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(76, 13);
            this.PhoneLabel.TabIndex = 12;
            this.PhoneLabel.Text = "Phone number";
            // 
            // phoneBox
            // 
            this.phoneBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.phoneBox.Location = new System.Drawing.Point(285, 150);
            this.phoneBox.MaxLength = 20;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(170, 20);
            this.phoneBox.TabIndex = 13;
            this.phoneBox.Tag = "e.g. +421 900 123 456";
            this.phoneBox.Text = "e.g. +421 900 123 456";
            this.phoneBox.Enter += new System.EventHandler(this.PhoneBox_Enter);
            this.phoneBox.Leave += new System.EventHandler(this.PhoneBox_Leave);
            // 
            // DateofBLabel
            // 
            this.DateofBLabel.AutoSize = true;
            this.DateofBLabel.Location = new System.Drawing.Point(36, 182);
            this.DateofBLabel.Name = "DateofBLabel";
            this.DateofBLabel.Size = new System.Drawing.Size(65, 13);
            this.DateofBLabel.TabIndex = 14;
            this.DateofBLabel.Text = "Date of birth";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(39, 199);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 15;
            // 
            // PlaceofBLabel
            // 
            this.PlaceofBLabel.AutoSize = true;
            this.PlaceofBLabel.Location = new System.Drawing.Point(282, 182);
            this.PlaceofBLabel.Name = "PlaceofBLabel";
            this.PlaceofBLabel.Size = new System.Drawing.Size(69, 13);
            this.PlaceofBLabel.TabIndex = 16;
            this.PlaceofBLabel.Text = "Place of birth";
            // 
            // placeofBBox
            // 
            this.placeofBBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.placeofBBox.Location = new System.Drawing.Point(285, 199);
            this.placeofBBox.MaxLength = 30;
            this.placeofBBox.Name = "placeofBBox";
            this.placeofBBox.Size = new System.Drawing.Size(170, 20);
            this.placeofBBox.TabIndex = 17;
            this.placeofBBox.Tag = "e.g. Wien";
            this.placeofBBox.Text = "e.g. Wien";
            this.placeofBBox.Enter += new System.EventHandler(this.PlaceofBBox_Enter);
            this.placeofBBox.Leave += new System.EventHandler(this.PlaceofBBox_Leave);
            // 
            // NationLabel
            // 
            this.NationLabel.AutoSize = true;
            this.NationLabel.Location = new System.Drawing.Point(36, 236);
            this.NationLabel.Name = "NationLabel";
            this.NationLabel.Size = new System.Drawing.Size(56, 13);
            this.NationLabel.TabIndex = 19;
            this.NationLabel.Text = "Nationality";
            // 
            // MaritalLabel
            // 
            this.MaritalLabel.AutoSize = true;
            this.MaritalLabel.Location = new System.Drawing.Point(163, 236);
            this.MaritalLabel.Name = "MaritalLabel";
            this.MaritalLabel.Size = new System.Drawing.Size(69, 13);
            this.MaritalLabel.TabIndex = 20;
            this.MaritalLabel.Text = "Marital status";
            // 
            // maritalComboBox
            // 
            this.maritalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maritalComboBox.FormattingEnabled = true;
            this.maritalComboBox.Items.AddRange(new object[] {
            "-- select --",
            "Single",
            "Married",
            "Widowed",
            "Divorced"});
            this.maritalComboBox.Location = new System.Drawing.Point(166, 250);
            this.maritalComboBox.Name = "maritalComboBox";
            this.maritalComboBox.Size = new System.Drawing.Size(97, 21);
            this.maritalComboBox.TabIndex = 22;
            // 
            // nationComboBox
            // 
            this.nationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nationComboBox.FormattingEnabled = true;
            this.nationComboBox.Location = new System.Drawing.Point(39, 249);
            this.nationComboBox.Name = "nationComboBox";
            this.nationComboBox.Size = new System.Drawing.Size(100, 21);
            this.nationComboBox.TabIndex = 21;
            // 
            // NextButton1
            // 
            this.NextButton1.Location = new System.Drawing.Point(450, 300);
            this.NextButton1.Name = "NextButton1";
            this.NextButton1.Size = new System.Drawing.Size(100, 30);
            this.NextButton1.TabIndex = 23;
            this.NextButton1.Text = "Next";
            this.NextButton1.UseVisualStyleBackColor = true;
            this.NextButton1.Click += new System.EventHandler(this.NextButton1_Click);
            // 
            // PersonalLabel
            // 
            this.PersonalLabel.AutoSize = true;
            this.PersonalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PersonalLabel.Location = new System.Drawing.Point(36, 9);
            this.PersonalLabel.Name = "PersonalLabel";
            this.PersonalLabel.Size = new System.Drawing.Size(121, 16);
            this.PersonalLabel.TabIndex = 24;
            this.PersonalLabel.Text = "Personal details";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(282, 236);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(110, 13);
            this.linkLabel.TabIndex = 25;
            this.linkLabel.Text = "Link to your reference";
            // 
            // linkTextBox
            // 
            this.linkTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.linkTextBox.Location = new System.Drawing.Point(285, 251);
            this.linkTextBox.MaxLength = 300;
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(170, 20);
            this.linkTextBox.TabIndex = 26;
            this.linkTextBox.Tag = "e.g. https://github.com/example";
            this.linkTextBox.Text = "e.g. https://github.com/example";
            this.linkTextBox.Enter += new System.EventHandler(this.linkTextBox_Enter);
            this.linkTextBox.Leave += new System.EventHandler(this.linkTextBox_Leave);
            // 
            // linkTip
            // 
            this.linkTip.AutoPopDelay = 15000;
            this.linkTip.InitialDelay = 500;
            this.linkTip.IsBalloon = true;
            this.linkTip.ReshowDelay = 100;
            this.linkTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.linkTip.ToolTipTitle = "Notice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(461, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "!";
            this.linkTip.SetToolTip(this.label1, "If you want add 2 or more links, you must separate them by character: |");
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(285, 44);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(75, 23);
            this.fileButton.TabIndex = 27;
            this.fileButton.Text = "Open file..";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(282, 31);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(134, 13);
            this.imageLabel.TabIndex = 28;
            this.imageLabel.Text = "Choose your photo as *.jpg";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.infoLabel.Location = new System.Drawing.Point(39, 316);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(32, 16);
            this.infoLabel.TabIndex = 29;
            this.infoLabel.Text = "Info";
            this.infoTip.SetToolTip(this.infoLabel, "The fields in this section are not all necessary. These fields which you did not " +
        "fill, they will not be included in your final CV document.");
            // 
            // infoTip
            // 
            this.infoTip.AutoPopDelay = 15000;
            this.infoTip.InitialDelay = 500;
            this.infoTip.IsBalloon = true;
            this.infoTip.ReshowDelay = 100;
            this.infoTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.infoTip.ToolTipTitle = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.PersonalLabel);
            this.Controls.Add(this.NextButton1);
            this.Controls.Add(this.nationComboBox);
            this.Controls.Add(this.maritalComboBox);
            this.Controls.Add(this.MaritalLabel);
            this.Controls.Add(this.NationLabel);
            this.Controls.Add(this.placeofBBox);
            this.Controls.Add(this.PlaceofBLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.DateofBLabel);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.zipcodeBox);
            this.Controls.Add(this.ZipcodeLabel);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.nameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV Maker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label ZipcodeLabel;
        private System.Windows.Forms.TextBox zipcodeBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label DateofBLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label PlaceofBLabel;
        private System.Windows.Forms.TextBox placeofBBox;
        private System.Windows.Forms.Label NationLabel;
        private System.Windows.Forms.Label MaritalLabel;
        private System.Windows.Forms.ComboBox maritalComboBox;
        private System.Windows.Forms.ComboBox nationComboBox;
        private System.Windows.Forms.Button NextButton1;
        private System.Windows.Forms.Label PersonalLabel;
        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.ToolTip linkTip;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ToolTip infoTip;
        private System.Windows.Forms.Label label1;
    }
}

