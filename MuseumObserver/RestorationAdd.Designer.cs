namespace MuseumObserver
{
    partial class RestorationAdd
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
            this.comboBoxExhibit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveNewRestorationButton = new System.Windows.Forms.Button();
            this.RestorationRestorerComboBox = new System.Windows.Forms.ComboBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.setPhotoButton = new System.Windows.Forms.Button();
            this.RestorationEnd = new System.Windows.Forms.DateTimePicker();
            this.RestorationStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxExhibit
            // 
            this.comboBoxExhibit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExhibit.FormattingEnabled = true;
            this.comboBoxExhibit.Location = new System.Drawing.Point(407, 154);
            this.comboBoxExhibit.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxExhibit.Name = "comboBoxExhibit";
            this.comboBoxExhibit.Size = new System.Drawing.Size(257, 24);
            this.comboBoxExhibit.TabIndex = 95;
            this.comboBoxExhibit.SelectedIndexChanged += new System.EventHandler(this.ComboBoxExhibit_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Экспонат";
            // 
            // SaveNewRestorationButton
            // 
            this.SaveNewRestorationButton.Location = new System.Drawing.Point(492, 186);
            this.SaveNewRestorationButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveNewRestorationButton.Name = "SaveNewRestorationButton";
            this.SaveNewRestorationButton.Size = new System.Drawing.Size(172, 28);
            this.SaveNewRestorationButton.TabIndex = 84;
            this.SaveNewRestorationButton.Text = "Сохранить";
            this.SaveNewRestorationButton.UseVisualStyleBackColor = true;
            this.SaveNewRestorationButton.Click += new System.EventHandler(this.SaveNewRestorationButton_Click);
            // 
            // RestorationRestorerComboBox
            // 
            this.RestorationRestorerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RestorationRestorerComboBox.FormattingEnabled = true;
            this.RestorationRestorerComboBox.Location = new System.Drawing.Point(407, 45);
            this.RestorationRestorerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.RestorationRestorerComboBox.Name = "RestorationRestorerComboBox";
            this.RestorationRestorerComboBox.Size = new System.Drawing.Size(257, 24);
            this.RestorationRestorerComboBox.TabIndex = 93;
            this.RestorationRestorerComboBox.SelectedIndexChanged += new System.EventHandler(this.RestorationRestorerComboBox_SelectedIndexChanged);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(12, 11);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(280, 255);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 92;
            this.photoPictureBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 273);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(652, 259);
            this.descriptionTextBox.TabIndex = 91;
            // 
            // setPhotoButton
            // 
            this.setPhotoButton.Location = new System.Drawing.Point(305, 186);
            this.setPhotoButton.Margin = new System.Windows.Forms.Padding(4);
            this.setPhotoButton.Name = "setPhotoButton";
            this.setPhotoButton.Size = new System.Drawing.Size(172, 28);
            this.setPhotoButton.TabIndex = 90;
            this.setPhotoButton.Text = "Добавить фото";
            this.setPhotoButton.UseVisualStyleBackColor = true;
            this.setPhotoButton.Click += new System.EventHandler(this.SetPhotoButton_Click);
            // 
            // RestorationEnd
            // 
            this.RestorationEnd.Location = new System.Drawing.Point(492, 124);
            this.RestorationEnd.Margin = new System.Windows.Forms.Padding(4);
            this.RestorationEnd.Name = "RestorationEnd";
            this.RestorationEnd.Size = new System.Drawing.Size(172, 22);
            this.RestorationEnd.TabIndex = 89;
            // 
            // RestorationStart
            // 
            this.RestorationStart.Location = new System.Drawing.Point(492, 86);
            this.RestorationStart.Margin = new System.Windows.Forms.Padding(4);
            this.RestorationStart.Name = "RestorationStart";
            this.RestorationStart.Size = new System.Drawing.Size(172, 22);
            this.RestorationStart.TabIndex = 88;
            this.RestorationStart.ValueChanged += new System.EventHandler(this.RestorationStart_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 87;
            this.label7.Text = "Окончание реставрации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 86;
            this.label6.Text = "Начало реставрации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 85;
            this.label5.Text = "Реставратор";
            // 
            // RestorationAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 541);
            this.Controls.Add(this.comboBoxExhibit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveNewRestorationButton);
            this.Controls.Add(this.RestorationRestorerComboBox);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.setPhotoButton);
            this.Controls.Add(this.RestorationEnd);
            this.Controls.Add(this.RestorationStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "RestorationAdd";
            this.Text = "RestorationAdd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RestorationAdd_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxExhibit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveNewRestorationButton;
        private System.Windows.Forms.ComboBox RestorationRestorerComboBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button setPhotoButton;
        private System.Windows.Forms.DateTimePicker RestorationEnd;
        private System.Windows.Forms.DateTimePicker RestorationStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}