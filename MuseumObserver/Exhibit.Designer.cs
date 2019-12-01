namespace MuseumObserver
{
    partial class Exhibit
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
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.appearanceDateLabel = new System.Windows.Forms.Label();
            this.appearanceDateFrom = new System.Windows.Forms.DateTimePicker();
            this.appearanceDateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exhibitListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.appearanceDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.setPhotoButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxExhibitCategor = new System.Windows.Forms.ComboBox();
            this.comboBoxGetFrom = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMuseum = new System.Windows.Forms.RadioButton();
            this.radioMaecenas = new System.Windows.Forms.RadioButton();
            this.checkBoxTimeFilter = new System.Windows.Forms.CheckBox();
            this.buttonRememberChenged = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Museums = new System.Windows.Forms.ToolStripMenuItem();
            this.Maecenas = new System.Windows.Forms.ToolStripMenuItem();
            this.Rents = new System.Windows.Forms.ToolStripMenuItem();
            this.Restorations = new System.Windows.Forms.ToolStripMenuItem();
            this.Restorations1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Restorersa = new System.Windows.Forms.ToolStripMenuItem();
            this.Exhibitions = new System.Windows.Forms.ToolStripMenuItem();
            this.Exhibitions1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Showrooms = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(92, 38);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(165, 24);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(13, 41);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(77, 17);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Категория";
            // 
            // appearanceDateLabel
            // 
            this.appearanceDateLabel.AutoSize = true;
            this.appearanceDateLabel.Location = new System.Drawing.Point(40, 69);
            this.appearanceDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appearanceDateLabel.Name = "appearanceDateLabel";
            this.appearanceDateLabel.Size = new System.Drawing.Size(171, 17);
            this.appearanceDateLabel.TabIndex = 2;
            this.appearanceDateLabel.Text = "Дата появления в музее";
            // 
            // appearanceDateFrom
            // 
            this.appearanceDateFrom.Location = new System.Drawing.Point(49, 90);
            this.appearanceDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.appearanceDateFrom.Name = "appearanceDateFrom";
            this.appearanceDateFrom.Size = new System.Drawing.Size(172, 22);
            this.appearanceDateFrom.TabIndex = 4;
            this.appearanceDateFrom.ValueChanged += new System.EventHandler(this.AppearanceDateFrom_ValueChanged);
            // 
            // appearanceDateTo
            // 
            this.appearanceDateTo.Location = new System.Drawing.Point(49, 122);
            this.appearanceDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.appearanceDateTo.Name = "appearanceDateTo";
            this.appearanceDateTo.Size = new System.Drawing.Size(172, 22);
            this.appearanceDateTo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "до";
            // 
            // exhibitListBox
            // 
            this.exhibitListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.exhibitListBox.FormattingEnabled = true;
            this.exhibitListBox.ItemHeight = 16;
            this.exhibitListBox.Location = new System.Drawing.Point(13, 185);
            this.exhibitListBox.Margin = new System.Windows.Forms.Padding(4);
            this.exhibitListBox.Name = "exhibitListBox";
            this.exhibitListBox.Size = new System.Drawing.Size(244, 244);
            this.exhibitListBox.TabIndex = 12;
            this.exhibitListBox.SelectedIndexChanged += new System.EventHandler(this.exhibitListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Название экспоната";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата появления в музее";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата создания";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(722, 41);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 22);
            this.nameTextBox.TabIndex = 16;
            // 
            // appearanceDate
            // 
            this.appearanceDate.Location = new System.Drawing.Point(778, 71);
            this.appearanceDate.Margin = new System.Windows.Forms.Padding(4);
            this.appearanceDate.Name = "appearanceDate";
            this.appearanceDate.Size = new System.Drawing.Size(172, 22);
            this.appearanceDate.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(677, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Экспонат получен от";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(564, 246);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Категория";
            // 
            // setPhotoButton
            // 
            this.setPhotoButton.Location = new System.Drawing.Point(567, 275);
            this.setPhotoButton.Margin = new System.Windows.Forms.Padding(4);
            this.setPhotoButton.Name = "setPhotoButton";
            this.setPhotoButton.Size = new System.Drawing.Size(172, 28);
            this.setPhotoButton.TabIndex = 23;
            this.setPhotoButton.Text = "Добавить фото";
            this.setPhotoButton.UseVisualStyleBackColor = true;
            this.setPhotoButton.Click += new System.EventHandler(this.SetPhotoButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(268, 311);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(682, 189);
            this.descriptionTextBox.TabIndex = 24;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(13, 437);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(244, 28);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(13, 472);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 28);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Location = new System.Drawing.Point(138, 473);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(119, 28);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(268, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxExhibitCategor
            // 
            this.comboBoxExhibitCategor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExhibitCategor.FormattingEnabled = true;
            this.comboBoxExhibitCategor.Location = new System.Drawing.Point(650, 243);
            this.comboBoxExhibitCategor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxExhibitCategor.Name = "comboBoxExhibitCategor";
            this.comboBoxExhibitCategor.Size = new System.Drawing.Size(300, 24);
            this.comboBoxExhibitCategor.TabIndex = 29;
            this.comboBoxExhibitCategor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxExhibitCategor_SelectedIndexChanged);
            // 
            // comboBoxGetFrom
            // 
            this.comboBoxGetFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGetFrom.FormattingEnabled = true;
            this.comboBoxGetFrom.Location = new System.Drawing.Point(567, 151);
            this.comboBoxGetFrom.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGetFrom.Name = "comboBoxGetFrom";
            this.comboBoxGetFrom.Size = new System.Drawing.Size(383, 24);
            this.comboBoxGetFrom.TabIndex = 30;
            this.comboBoxGetFrom.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGetFrom_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMuseum);
            this.groupBox1.Controls.Add(this.radioMaecenas);
            this.groupBox1.Location = new System.Drawing.Point(650, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 54);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбранный даритель";
            // 
            // radioMuseum
            // 
            this.radioMuseum.AutoSize = true;
            this.radioMuseum.Location = new System.Drawing.Point(111, 21);
            this.radioMuseum.Name = "radioMuseum";
            this.radioMuseum.Size = new System.Drawing.Size(70, 21);
            this.radioMuseum.TabIndex = 1;
            this.radioMuseum.Text = "Музей";
            this.radioMuseum.UseVisualStyleBackColor = true;
            this.radioMuseum.CheckedChanged += new System.EventHandler(this.RadioMuseum_CheckedChanged);
            // 
            // radioMaecenas
            // 
            this.radioMaecenas.AutoSize = true;
            this.radioMaecenas.Checked = true;
            this.radioMaecenas.Location = new System.Drawing.Point(18, 21);
            this.radioMaecenas.Name = "radioMaecenas";
            this.radioMaecenas.Size = new System.Drawing.Size(87, 21);
            this.radioMaecenas.TabIndex = 0;
            this.radioMaecenas.TabStop = true;
            this.radioMaecenas.Text = "Меценат";
            this.radioMaecenas.UseVisualStyleBackColor = true;
            this.radioMaecenas.CheckedChanged += new System.EventHandler(this.RadioMecenat_CheckedChanged);
            // 
            // checkBoxTimeFilter
            // 
            this.checkBoxTimeFilter.AutoSize = true;
            this.checkBoxTimeFilter.Location = new System.Drawing.Point(16, 152);
            this.checkBoxTimeFilter.Name = "checkBoxTimeFilter";
            this.checkBoxTimeFilter.Size = new System.Drawing.Size(201, 21);
            this.checkBoxTimeFilter.TabIndex = 32;
            this.checkBoxTimeFilter.Text = "Фильтрацния по времени";
            this.checkBoxTimeFilter.UseVisualStyleBackColor = true;
            this.checkBoxTimeFilter.CheckedChanged += new System.EventHandler(this.CheckBoxTimeFilter_CheckedChanged);
            // 
            // buttonRememberChenged
            // 
            this.buttonRememberChenged.Location = new System.Drawing.Point(778, 275);
            this.buttonRememberChenged.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRememberChenged.Name = "buttonRememberChenged";
            this.buttonRememberChenged.Size = new System.Drawing.Size(172, 28);
            this.buttonRememberChenged.TabIndex = 33;
            this.buttonRememberChenged.Text = "Запомнить изменения";
            this.buttonRememberChenged.UseVisualStyleBackColor = true;
            this.buttonRememberChenged.Click += new System.EventHandler(this.ButtonRememberChenged_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Museums,
            this.Maecenas,
            this.Rents,
            this.Restorations,
            this.Exhibitions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 28);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Museums
            // 
            this.Museums.Name = "Museums";
            this.Museums.Size = new System.Drawing.Size(67, 24);
            this.Museums.Text = "Музеи";
            this.Museums.Click += new System.EventHandler(this.Museums_Click);
            // 
            // Maecenas
            // 
            this.Maecenas.Name = "Maecenas";
            this.Maecenas.Size = new System.Drawing.Size(95, 24);
            this.Maecenas.Text = "Меценаты";
            this.Maecenas.Click += new System.EventHandler(this.Maecenas_Click);
            // 
            // Rents
            // 
            this.Rents.Name = "Rents";
            this.Rents.Size = new System.Drawing.Size(78, 24);
            this.Rents.Text = "Аренды";
            this.Rents.Click += new System.EventHandler(this.Rents_Click);
            // 
            // Restorations
            // 
            this.Restorations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Restorations1,
            this.Restorersa});
            this.Restorations.Name = "Restorations";
            this.Restorations.Size = new System.Drawing.Size(112, 24);
            this.Restorations.Text = "Реставрации";
            // 
            // Restorations1
            // 
            this.Restorations1.Name = "Restorations1";
            this.Restorations1.Size = new System.Drawing.Size(189, 26);
            this.Restorations1.Text = "Реставрации";
            this.Restorations1.Click += new System.EventHandler(this.Restorations1_Click);
            // 
            // Restorersa
            // 
            this.Restorersa.Name = "Restorersa";
            this.Restorersa.Size = new System.Drawing.Size(189, 26);
            this.Restorersa.Text = "Реставраторы";
            // 
            // Exhibitions
            // 
            this.Exhibitions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exhibitions1,
            this.Showrooms});
            this.Exhibitions.Name = "Exhibitions";
            this.Exhibitions.Size = new System.Drawing.Size(88, 24);
            this.Exhibitions.Text = "Выставки";
            // 
            // Exhibitions1
            // 
            this.Exhibitions1.Name = "Exhibitions1";
            this.Exhibitions1.Size = new System.Drawing.Size(157, 26);
            this.Exhibitions1.Text = "Выставки";
            this.Exhibitions1.Click += new System.EventHandler(this.Exhibitions1_Click);
            // 
            // Showrooms
            // 
            this.Showrooms.Name = "Showrooms";
            this.Showrooms.Size = new System.Drawing.Size(157, 26);
            this.Showrooms.Text = "Залы";
            this.Showrooms.Click += new System.EventHandler(this.Showrooms_Click);
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(680, 98);
            this.TimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(270, 22);
            this.TimeTextBox.TabIndex = 35;
            // 
            // Exhibit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 513);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.buttonRememberChenged);
            this.Controls.Add(this.checkBoxTimeFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxGetFrom);
            this.Controls.Add(this.comboBoxExhibitCategor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.setPhotoButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.appearanceDate);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exhibitListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appearanceDateTo);
            this.Controls.Add(this.appearanceDateFrom);
            this.Controls.Add(this.appearanceDateLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(985, 900);
            this.MinimumSize = new System.Drawing.Size(985, 560);
            this.Name = "Exhibit";
            this.Text = "Экспонаты";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label appearanceDateLabel;
        private System.Windows.Forms.DateTimePicker appearanceDateFrom;
        private System.Windows.Forms.DateTimePicker appearanceDateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox exhibitListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker appearanceDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button setPhotoButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxExhibitCategor;
        private System.Windows.Forms.ComboBox comboBoxGetFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMuseum;
        private System.Windows.Forms.RadioButton radioMaecenas;
        private System.Windows.Forms.CheckBox checkBoxTimeFilter;
        private System.Windows.Forms.Button buttonRememberChenged;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Museums;
        private System.Windows.Forms.ToolStripMenuItem Maecenas;
        private System.Windows.Forms.ToolStripMenuItem Rents;
        private System.Windows.Forms.ToolStripMenuItem Restorations;
        private System.Windows.Forms.ToolStripMenuItem Restorations1;
        private System.Windows.Forms.ToolStripMenuItem Restorersa;
        private System.Windows.Forms.ToolStripMenuItem Exhibitions;
        private System.Windows.Forms.ToolStripMenuItem Exhibitions1;
        private System.Windows.Forms.ToolStripMenuItem Showrooms;
        private System.Windows.Forms.TextBox TimeTextBox;
    }
}