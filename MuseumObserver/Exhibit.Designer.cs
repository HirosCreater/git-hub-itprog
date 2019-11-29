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
            this.createdDateLabel = new System.Windows.Forms.Label();
            this.appearanceDateFrom = new System.Windows.Forms.DateTimePicker();
            this.appearanceDateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createdDateTo = new System.Windows.Forms.DateTimePicker();
            this.createdDateFrom = new System.Windows.Forms.DateTimePicker();
            this.exhibitListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.appearanceDate = new System.Windows.Forms.DateTimePicker();
            this.createdDate = new System.Windows.Forms.DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(101, 6);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(160, 24);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(13, 9);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(77, 17);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Категория";
            // 
            // appearanceDateLabel
            // 
            this.appearanceDateLabel.AutoSize = true;
            this.appearanceDateLabel.Location = new System.Drawing.Point(54, 43);
            this.appearanceDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appearanceDateLabel.Name = "appearanceDateLabel";
            this.appearanceDateLabel.Size = new System.Drawing.Size(171, 17);
            this.appearanceDateLabel.TabIndex = 2;
            this.appearanceDateLabel.Text = "Дата появления в музее";
            // 
            // createdDateLabel
            // 
            this.createdDateLabel.AutoSize = true;
            this.createdDateLabel.Location = new System.Drawing.Point(49, 160);
            this.createdDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createdDateLabel.Name = "createdDateLabel";
            this.createdDateLabel.Size = new System.Drawing.Size(108, 17);
            this.createdDateLabel.TabIndex = 3;
            this.createdDateLabel.Text = "Дата создания";
            // 
            // appearanceDateFrom
            // 
            this.appearanceDateFrom.Location = new System.Drawing.Point(58, 74);
            this.appearanceDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.appearanceDateFrom.Name = "appearanceDateFrom";
            this.appearanceDateFrom.Size = new System.Drawing.Size(172, 22);
            this.appearanceDateFrom.TabIndex = 4;
            this.appearanceDateFrom.ValueChanged += new System.EventHandler(this.AppearanceDateFrom_ValueChanged);
            // 
            // appearanceDateTo
            // 
            this.appearanceDateTo.Location = new System.Drawing.Point(58, 106);
            this.appearanceDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.appearanceDateTo.Name = "appearanceDateTo";
            this.appearanceDateTo.Size = new System.Drawing.Size(172, 22);
            this.appearanceDateTo.TabIndex = 5;
            this.appearanceDateTo.ValueChanged += new System.EventHandler(this.AppearanceDateTo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "от";
            // 
            // createdDateTo
            // 
            this.createdDateTo.Location = new System.Drawing.Point(53, 222);
            this.createdDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.createdDateTo.Name = "createdDateTo";
            this.createdDateTo.Size = new System.Drawing.Size(172, 22);
            this.createdDateTo.TabIndex = 9;
            // 
            // createdDateFrom
            // 
            this.createdDateFrom.Location = new System.Drawing.Point(53, 190);
            this.createdDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.createdDateFrom.Name = "createdDateFrom";
            this.createdDateFrom.Size = new System.Drawing.Size(172, 22);
            this.createdDateFrom.TabIndex = 8;
            // 
            // exhibitListBox
            // 
            this.exhibitListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.exhibitListBox.FormattingEnabled = true;
            this.exhibitListBox.ItemHeight = 16;
            this.exhibitListBox.Location = new System.Drawing.Point(17, 270);
            this.exhibitListBox.Margin = new System.Windows.Forms.Padding(4);
            this.exhibitListBox.Name = "exhibitListBox";
            this.exhibitListBox.Size = new System.Drawing.Size(244, 180);
            this.exhibitListBox.TabIndex = 12;
            this.exhibitListBox.SelectedIndexChanged += new System.EventHandler(this.exhibitListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Название экспоната";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата появления в музее";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата создания";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(750, 13);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 22);
            this.nameTextBox.TabIndex = 16;
            // 
            // appearanceDate
            // 
            this.appearanceDate.Location = new System.Drawing.Point(806, 43);
            this.appearanceDate.Margin = new System.Windows.Forms.Padding(4);
            this.appearanceDate.Name = "appearanceDate";
            this.appearanceDate.Size = new System.Drawing.Size(172, 22);
            this.appearanceDate.TabIndex = 17;
            // 
            // createdDate
            // 
            this.createdDate.Location = new System.Drawing.Point(806, 73);
            this.createdDate.Margin = new System.Windows.Forms.Padding(4);
            this.createdDate.Name = "createdDate";
            this.createdDate.Size = new System.Drawing.Size(172, 22);
            this.createdDate.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(705, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Экспонат получен от";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(592, 218);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Категория";
            // 
            // setPhotoButton
            // 
            this.setPhotoButton.Location = new System.Drawing.Point(595, 247);
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
            this.descriptionTextBox.Location = new System.Drawing.Point(296, 283);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(682, 246);
            this.descriptionTextBox.TabIndex = 24;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(17, 459);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(245, 28);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(17, 494);
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
            this.deleteButton.Location = new System.Drawing.Point(144, 494);
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
            this.pictureBox1.Location = new System.Drawing.Point(296, 6);
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
            this.comboBoxExhibitCategor.Location = new System.Drawing.Point(678, 215);
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
            this.comboBoxGetFrom.Location = new System.Drawing.Point(595, 123);
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
            this.groupBox1.Location = new System.Drawing.Point(678, 154);
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
            this.checkBoxTimeFilter.Location = new System.Drawing.Point(29, 136);
            this.checkBoxTimeFilter.Name = "checkBoxTimeFilter";
            this.checkBoxTimeFilter.Size = new System.Drawing.Size(201, 21);
            this.checkBoxTimeFilter.TabIndex = 32;
            this.checkBoxTimeFilter.Text = "Фильтрацния по времени";
            this.checkBoxTimeFilter.UseVisualStyleBackColor = true;
            this.checkBoxTimeFilter.CheckedChanged += new System.EventHandler(this.CheckBoxTimeFilter_CheckedChanged);
            // 
            // buttonRememberChenged
            // 
            this.buttonRememberChenged.Location = new System.Drawing.Point(806, 247);
            this.buttonRememberChenged.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRememberChenged.Name = "buttonRememberChenged";
            this.buttonRememberChenged.Size = new System.Drawing.Size(172, 28);
            this.buttonRememberChenged.TabIndex = 33;
            this.buttonRememberChenged.Text = "Запомнить изменения";
            this.buttonRememberChenged.UseVisualStyleBackColor = true;
            this.buttonRememberChenged.Click += new System.EventHandler(this.ButtonRememberChenged_Click);
            // 
            // Exhibit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 543);
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
            this.Controls.Add(this.createdDate);
            this.Controls.Add(this.appearanceDate);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exhibitListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createdDateTo);
            this.Controls.Add(this.createdDateFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appearanceDateTo);
            this.Controls.Add(this.appearanceDateFrom);
            this.Controls.Add(this.createdDateLabel);
            this.Controls.Add(this.appearanceDateLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1010, 800);
            this.MinimumSize = new System.Drawing.Size(1010, 590);
            this.Name = "Exhibit";
            this.Text = "Экспонаты";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label appearanceDateLabel;
        private System.Windows.Forms.Label createdDateLabel;
        private System.Windows.Forms.DateTimePicker appearanceDateFrom;
        private System.Windows.Forms.DateTimePicker appearanceDateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker createdDateTo;
        private System.Windows.Forms.DateTimePicker createdDateFrom;
        private System.Windows.Forms.ListBox exhibitListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker appearanceDate;
        private System.Windows.Forms.DateTimePicker createdDate;
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
    }
}