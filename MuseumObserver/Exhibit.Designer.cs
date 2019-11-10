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
            this.crutchTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.setPhotoButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(97, 12);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(31, 15);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(60, 13);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Категория";
            this.categoryLabel.Click += new System.EventHandler(this.categoryLabel_Click);
            // 
            // appearanceDateLabel
            // 
            this.appearanceDateLabel.AutoSize = true;
            this.appearanceDateLabel.Location = new System.Drawing.Point(58, 47);
            this.appearanceDateLabel.Name = "appearanceDateLabel";
            this.appearanceDateLabel.Size = new System.Drawing.Size(133, 13);
            this.appearanceDateLabel.TabIndex = 2;
            this.appearanceDateLabel.Text = "Дата появления в музее";
            // 
            // createdDateLabel
            // 
            this.createdDateLabel.AutoSize = true;
            this.createdDateLabel.Location = new System.Drawing.Point(58, 137);
            this.createdDateLabel.Name = "createdDateLabel";
            this.createdDateLabel.Size = new System.Drawing.Size(84, 13);
            this.createdDateLabel.TabIndex = 3;
            this.createdDateLabel.Text = "Дата создания";
            this.createdDateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // appearanceDateFrom
            // 
            this.appearanceDateFrom.Location = new System.Drawing.Point(61, 72);
            this.appearanceDateFrom.Name = "appearanceDateFrom";
            this.appearanceDateFrom.Size = new System.Drawing.Size(130, 20);
            this.appearanceDateFrom.TabIndex = 4;
            // 
            // appearanceDateTo
            // 
            this.appearanceDateTo.Location = new System.Drawing.Point(61, 98);
            this.appearanceDateTo.Name = "appearanceDateTo";
            this.appearanceDateTo.Size = new System.Drawing.Size(130, 20);
            this.appearanceDateTo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "от";
            // 
            // createdDateTo
            // 
            this.createdDateTo.Location = new System.Drawing.Point(61, 188);
            this.createdDateTo.Name = "createdDateTo";
            this.createdDateTo.Size = new System.Drawing.Size(130, 20);
            this.createdDateTo.TabIndex = 9;
            // 
            // createdDateFrom
            // 
            this.createdDateFrom.Location = new System.Drawing.Point(61, 162);
            this.createdDateFrom.Name = "createdDateFrom";
            this.createdDateFrom.Size = new System.Drawing.Size(130, 20);
            this.createdDateFrom.TabIndex = 8;
            // 
            // exhibitListBox
            // 
            this.exhibitListBox.FormattingEnabled = true;
            this.exhibitListBox.Location = new System.Drawing.Point(34, 227);
            this.exhibitListBox.Name = "exhibitListBox";
            this.exhibitListBox.Size = new System.Drawing.Size(184, 147);
            this.exhibitListBox.TabIndex = 12;
            this.exhibitListBox.SelectedIndexChanged += new System.EventHandler(this.exhibitListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Название экспоната";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата появления в музее";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата создания";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(676, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(172, 20);
            this.nameTextBox.TabIndex = 16;
            // 
            // appearanceDate
            // 
            this.appearanceDate.Location = new System.Drawing.Point(718, 72);
            this.appearanceDate.Name = "appearanceDate";
            this.appearanceDate.Size = new System.Drawing.Size(130, 20);
            this.appearanceDate.TabIndex = 17;
            // 
            // createdDate
            // 
            this.createdDate.Location = new System.Drawing.Point(718, 103);
            this.createdDate.Name = "createdDate";
            this.createdDate.Size = new System.Drawing.Size(130, 20);
            this.createdDate.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Экспонат получен от";
            // 
            // crutchTextBox
            // 
            this.crutchTextBox.Location = new System.Drawing.Point(676, 137);
            this.crutchTextBox.Name = "crutchTextBox";
            this.crutchTextBox.Size = new System.Drawing.Size(172, 20);
            this.crutchTextBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(558, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Категория";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(676, 169);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(172, 20);
            this.categoryTextBox.TabIndex = 22;
            // 
            // setPhotoButton
            // 
            this.setPhotoButton.Location = new System.Drawing.Point(560, 195);
            this.setPhotoButton.Name = "setPhotoButton";
            this.setPhotoButton.Size = new System.Drawing.Size(129, 23);
            this.setPhotoButton.TabIndex = 23;
            this.setPhotoButton.Text = "Добавить фото";
            this.setPhotoButton.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(243, 227);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(605, 211);
            this.descriptionTextBox.TabIndex = 24;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(34, 380);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(184, 23);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(34, 409);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 23);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(129, 409);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 23);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // Exhibit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.setPhotoButton);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.crutchTextBox);
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
            this.Name = "Exhibit";
            this.Text = "Экспонаты";
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
        private System.Windows.Forms.TextBox crutchTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Button setPhotoButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
    }
}