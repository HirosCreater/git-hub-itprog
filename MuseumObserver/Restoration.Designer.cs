namespace MuseumObserver
{
    partial class Restoration
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
            this.TimeFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBoxExhibit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RememberChangesButton = new System.Windows.Forms.Button();
            this.RestorationRestorerComboBox = new System.Windows.Forms.ComboBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.setPhotoButton = new System.Windows.Forms.Button();
            this.RestorationEnd = new System.Windows.Forms.DateTimePicker();
            this.RestorationStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RestorationListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appearanceDateTo = new System.Windows.Forms.DateTimePicker();
            this.appearanceDateFrom = new System.Windows.Forms.DateTimePicker();
            this.appearanceDateLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.restorerComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeFilterCheckBox
            // 
            this.TimeFilterCheckBox.AutoSize = true;
            this.TimeFilterCheckBox.Location = new System.Drawing.Point(85, 119);
            this.TimeFilterCheckBox.Name = "TimeFilterCheckBox";
            this.TimeFilterCheckBox.Size = new System.Drawing.Size(198, 21);
            this.TimeFilterCheckBox.TabIndex = 84;
            this.TimeFilterCheckBox.Text = "Фильтровать по времени";
            this.TimeFilterCheckBox.UseVisualStyleBackColor = true;
            this.TimeFilterCheckBox.CheckedChanged += new System.EventHandler(this.TimeFilterCheckBox_CheckedChanged);
            // 
            // comboBoxExhibit
            // 
            this.comboBoxExhibit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExhibit.FormattingEnabled = true;
            this.comboBoxExhibit.Location = new System.Drawing.Point(800, 157);
            this.comboBoxExhibit.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxExhibit.Name = "comboBoxExhibit";
            this.comboBoxExhibit.Size = new System.Drawing.Size(257, 24);
            this.comboBoxExhibit.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(699, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 82;
            this.label3.Text = "Экспонат";
            // 
            // RememberChangesButton
            // 
            this.RememberChangesButton.Location = new System.Drawing.Point(885, 189);
            this.RememberChangesButton.Margin = new System.Windows.Forms.Padding(4);
            this.RememberChangesButton.Name = "RememberChangesButton";
            this.RememberChangesButton.Size = new System.Drawing.Size(172, 28);
            this.RememberChangesButton.TabIndex = 66;
            this.RememberChangesButton.Text = "Запомнить изменения";
            this.RememberChangesButton.UseVisualStyleBackColor = true;
            this.RememberChangesButton.Click += new System.EventHandler(this.RememberChangesButton_Click);
            // 
            // RestorationRestorerComboBox
            // 
            this.RestorationRestorerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RestorationRestorerComboBox.FormattingEnabled = true;
            this.RestorationRestorerComboBox.Location = new System.Drawing.Point(800, 48);
            this.RestorationRestorerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.RestorationRestorerComboBox.Name = "RestorationRestorerComboBox";
            this.RestorationRestorerComboBox.Size = new System.Drawing.Size(257, 24);
            this.RestorationRestorerComboBox.TabIndex = 81;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(405, 14);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(280, 255);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 80;
            this.photoPictureBox.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(194, 507);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(119, 28);
            this.deleteButton.TabIndex = 79;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(67, 507);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 28);
            this.addButton.TabIndex = 78;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(67, 471);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(245, 28);
            this.saveButton.TabIndex = 77;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(405, 276);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(652, 259);
            this.descriptionTextBox.TabIndex = 76;
            // 
            // setPhotoButton
            // 
            this.setPhotoButton.Location = new System.Drawing.Point(698, 189);
            this.setPhotoButton.Margin = new System.Windows.Forms.Padding(4);
            this.setPhotoButton.Name = "setPhotoButton";
            this.setPhotoButton.Size = new System.Drawing.Size(172, 28);
            this.setPhotoButton.TabIndex = 75;
            this.setPhotoButton.Text = "Добавить фото";
            this.setPhotoButton.UseVisualStyleBackColor = true;
            this.setPhotoButton.Click += new System.EventHandler(this.SetPhotoButton_Click);
            // 
            // RestorationEnd
            // 
            this.RestorationEnd.Location = new System.Drawing.Point(885, 127);
            this.RestorationEnd.Margin = new System.Windows.Forms.Padding(4);
            this.RestorationEnd.Name = "RestorationEnd";
            this.RestorationEnd.Size = new System.Drawing.Size(172, 22);
            this.RestorationEnd.TabIndex = 74;
            // 
            // RestorationStart
            // 
            this.RestorationStart.Location = new System.Drawing.Point(885, 89);
            this.RestorationStart.Margin = new System.Windows.Forms.Padding(4);
            this.RestorationStart.Name = "RestorationStart";
            this.RestorationStart.Size = new System.Drawing.Size(172, 22);
            this.RestorationStart.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(699, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "Окончание реставрации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(699, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Начало реставрации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(699, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Реставратор";
            // 
            // RestorationListBox
            // 
            this.RestorationListBox.FormattingEnabled = true;
            this.RestorationListBox.ItemHeight = 16;
            this.RestorationListBox.Location = new System.Drawing.Point(13, 145);
            this.RestorationListBox.Margin = new System.Windows.Forms.Padding(4);
            this.RestorationListBox.Name = "RestorationListBox";
            this.RestorationListBox.Size = new System.Drawing.Size(358, 308);
            this.RestorationListBox.TabIndex = 69;
            this.RestorationListBox.SelectedIndexChanged += new System.EventHandler(this.ExhibitListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "до";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "от";
            // 
            // appearanceDateTo
            // 
            this.appearanceDateTo.Location = new System.Drawing.Point(114, 89);
            this.appearanceDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.appearanceDateTo.Name = "appearanceDateTo";
            this.appearanceDateTo.Size = new System.Drawing.Size(172, 22);
            this.appearanceDateTo.TabIndex = 65;
            // 
            // appearanceDateFrom
            // 
            this.appearanceDateFrom.Location = new System.Drawing.Point(114, 57);
            this.appearanceDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.appearanceDateFrom.Name = "appearanceDateFrom";
            this.appearanceDateFrom.Size = new System.Drawing.Size(172, 22);
            this.appearanceDateFrom.TabIndex = 64;
            // 
            // appearanceDateLabel
            // 
            this.appearanceDateLabel.AutoSize = true;
            this.appearanceDateLabel.Location = new System.Drawing.Point(75, 36);
            this.appearanceDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appearanceDateLabel.Name = "appearanceDateLabel";
            this.appearanceDateLabel.Size = new System.Drawing.Size(223, 17);
            this.appearanceDateLabel.TabIndex = 63;
            this.appearanceDateLabel.Text = "Временной период реставраций";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(13, 9);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(93, 17);
            this.categoryLabel.TabIndex = 62;
            this.categoryLabel.Text = "Реставратор";
            // 
            // restorerComboBox
            // 
            this.restorerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restorerComboBox.FormattingEnabled = true;
            this.restorerComboBox.Location = new System.Drawing.Point(114, 6);
            this.restorerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.restorerComboBox.Name = "restorerComboBox";
            this.restorerComboBox.Size = new System.Drawing.Size(257, 24);
            this.restorerComboBox.TabIndex = 61;
            this.restorerComboBox.SelectedIndexChanged += new System.EventHandler(this.restorerComboBox_SelectedIndexChanged);
            // 
            // Restoration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 551);
            this.Controls.Add(this.TimeFilterCheckBox);
            this.Controls.Add(this.comboBoxExhibit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RememberChangesButton);
            this.Controls.Add(this.RestorationRestorerComboBox);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.setPhotoButton);
            this.Controls.Add(this.RestorationEnd);
            this.Controls.Add(this.RestorationStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RestorationListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appearanceDateTo);
            this.Controls.Add(this.appearanceDateFrom);
            this.Controls.Add(this.appearanceDateLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.restorerComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Restoration";
            this.Text = "Реставрации";
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TimeFilterCheckBox;
        private System.Windows.Forms.ComboBox comboBoxExhibit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RememberChangesButton;
        private System.Windows.Forms.ComboBox RestorationRestorerComboBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button setPhotoButton;
        private System.Windows.Forms.DateTimePicker RestorationEnd;
        private System.Windows.Forms.DateTimePicker RestorationStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox RestorationListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker appearanceDateTo;
        private System.Windows.Forms.DateTimePicker appearanceDateFrom;
        private System.Windows.Forms.Label appearanceDateLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox restorerComboBox;
    }
}