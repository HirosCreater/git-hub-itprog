namespace MuseumObserver
{
    partial class ExhibitAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMuseum = new System.Windows.Forms.RadioButton();
            this.radioMaecenas = new System.Windows.Forms.RadioButton();
            this.comboBoxGetFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxExhibitCategor = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.setPhotoButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.createdDate = new System.Windows.Forms.DateTimePicker();
            this.appearanceDate = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveToDataset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMuseum);
            this.groupBox1.Controls.Add(this.radioMaecenas);
            this.groupBox1.Location = new System.Drawing.Point(394, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 54);
            this.groupBox1.TabIndex = 45;
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
            this.radioMaecenas.CheckedChanged += new System.EventHandler(this.RadioMaecenas_CheckedChanged);
            // 
            // comboBoxGetFrom
            // 
            this.comboBoxGetFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGetFrom.FormattingEnabled = true;
            this.comboBoxGetFrom.Location = new System.Drawing.Point(311, 189);
            this.comboBoxGetFrom.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGetFrom.Name = "comboBoxGetFrom";
            this.comboBoxGetFrom.Size = new System.Drawing.Size(383, 24);
            this.comboBoxGetFrom.TabIndex = 44;
            // 
            // comboBoxExhibitCategor
            // 
            this.comboBoxExhibitCategor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExhibitCategor.FormattingEnabled = true;
            this.comboBoxExhibitCategor.Location = new System.Drawing.Point(394, 221);
            this.comboBoxExhibitCategor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxExhibitCategor.Name = "comboBoxExhibitCategor";
            this.comboBoxExhibitCategor.Size = new System.Drawing.Size(300, 24);
            this.comboBoxExhibitCategor.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 289);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(682, 246);
            this.descriptionTextBox.TabIndex = 41;
            // 
            // setPhotoButton
            // 
            this.setPhotoButton.Location = new System.Drawing.Point(311, 253);
            this.setPhotoButton.Margin = new System.Windows.Forms.Padding(4);
            this.setPhotoButton.Name = "setPhotoButton";
            this.setPhotoButton.Size = new System.Drawing.Size(172, 28);
            this.setPhotoButton.TabIndex = 40;
            this.setPhotoButton.Text = "Добавить фото";
            this.setPhotoButton.UseVisualStyleBackColor = true;
            this.setPhotoButton.Click += new System.EventHandler(this.SetPhotoButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Категория";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Экспонат получен от";
            // 
            // createdDate
            // 
            this.createdDate.Location = new System.Drawing.Point(522, 79);
            this.createdDate.Margin = new System.Windows.Forms.Padding(4);
            this.createdDate.Name = "createdDate";
            this.createdDate.Size = new System.Drawing.Size(172, 22);
            this.createdDate.TabIndex = 37;
            // 
            // appearanceDate
            // 
            this.appearanceDate.Location = new System.Drawing.Point(522, 49);
            this.appearanceDate.Margin = new System.Windows.Forms.Padding(4);
            this.appearanceDate.Name = "appearanceDate";
            this.appearanceDate.Size = new System.Drawing.Size(172, 22);
            this.appearanceDate.TabIndex = 36;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(466, 19);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 22);
            this.nameTextBox.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Дата создания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Дата появления в музее";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Название экспоната";
            // 
            // SaveToDataset
            // 
            this.SaveToDataset.Location = new System.Drawing.Point(523, 253);
            this.SaveToDataset.Margin = new System.Windows.Forms.Padding(4);
            this.SaveToDataset.Name = "SaveToDataset";
            this.SaveToDataset.Size = new System.Drawing.Size(172, 28);
            this.SaveToDataset.TabIndex = 46;
            this.SaveToDataset.Text = "Сохранить";
            this.SaveToDataset.UseVisualStyleBackColor = true;
            this.SaveToDataset.Click += new System.EventHandler(this.SaveToDataset_Click);
            // 
            // ExhibitAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 548);
            this.Controls.Add(this.SaveToDataset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxGetFrom);
            this.Controls.Add(this.comboBoxExhibitCategor);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "ExhibitAdd";
            this.Text = "ExhibitAdd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExhibitAdd_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMuseum;
        private System.Windows.Forms.RadioButton radioMaecenas;
        private System.Windows.Forms.ComboBox comboBoxGetFrom;
        private System.Windows.Forms.ComboBox comboBoxExhibitCategor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button setPhotoButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker createdDate;
        private System.Windows.Forms.DateTimePicker appearanceDate;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveToDataset;
    }
}