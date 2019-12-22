namespace MuseumObserver
{
    partial class Rent
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RentListBox = new System.Windows.Forms.ListBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.museumComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateStartTo = new System.Windows.Forms.DateTimePicker();
            this.dateStartFrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.museumtenantComboBox = new System.Windows.Forms.ComboBox();
            this.rentEnd = new System.Windows.Forms.DateTimePicker();
            this.rentStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterByStartTime = new System.Windows.Forms.CheckBox();
            this.FilterByEndTime = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEndTo = new System.Windows.Forms.DateTimePicker();
            this.dateEndFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ExhibitCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(269, 522);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(119, 28);
            this.deleteButton.TabIndex = 55;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(142, 522);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 28);
            this.addButton.TabIndex = 54;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(142, 487);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(246, 28);
            this.saveButton.TabIndex = 53;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Музей-арендатор";
            // 
            // RentListBox
            // 
            this.RentListBox.FormattingEnabled = true;
            this.RentListBox.ItemHeight = 16;
            this.RentListBox.Location = new System.Drawing.Point(277, 47);
            this.RentListBox.Margin = new System.Windows.Forms.Padding(4);
            this.RentListBox.Name = "RentListBox";
            this.RentListBox.Size = new System.Drawing.Size(207, 276);
            this.RentListBox.TabIndex = 40;
            this.RentListBox.SelectedIndexChanged += new System.EventHandler(this.RentListBox_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(28, 18);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 17);
            this.categoryLabel.TabIndex = 29;
            this.categoryLabel.Text = "Музей";
            // 
            // museumComboBox
            // 
            this.museumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.museumComboBox.FormattingEnabled = true;
            this.museumComboBox.Location = new System.Drawing.Point(85, 15);
            this.museumComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.museumComboBox.Name = "museumComboBox";
            this.museumComboBox.Size = new System.Drawing.Size(399, 24);
            this.museumComboBox.TabIndex = 28;
            this.museumComboBox.SelectedIndexChanged += new System.EventHandler(this.museumComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "до";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 59;
            this.label11.Text = "от";
            // 
            // dateStartTo
            // 
            this.dateStartTo.Location = new System.Drawing.Point(75, 113);
            this.dateStartTo.Margin = new System.Windows.Forms.Padding(4);
            this.dateStartTo.Name = "dateStartTo";
            this.dateStartTo.Size = new System.Drawing.Size(172, 22);
            this.dateStartTo.TabIndex = 58;
            this.dateStartTo.ValueChanged += new System.EventHandler(this.DateStartTo_ValueChanged);
            // 
            // dateStartFrom
            // 
            this.dateStartFrom.Location = new System.Drawing.Point(75, 81);
            this.dateStartFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dateStartFrom.Name = "dateStartFrom";
            this.dateStartFrom.Size = new System.Drawing.Size(172, 22);
            this.dateStartFrom.TabIndex = 57;
            this.dateStartFrom.ValueChanged += new System.EventHandler(this.DateStartFrom_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 54);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 17);
            this.label12.TabIndex = 56;
            this.label12.Text = "Дата начала аренды";
            // 
            // museumtenantComboBox
            // 
            this.museumtenantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.museumtenantComboBox.FormattingEnabled = true;
            this.museumtenantComboBox.Location = new System.Drawing.Point(225, 338);
            this.museumtenantComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.museumtenantComboBox.Name = "museumtenantComboBox";
            this.museumtenantComboBox.Size = new System.Drawing.Size(215, 24);
            this.museumtenantComboBox.TabIndex = 61;
            this.museumtenantComboBox.SelectedIndexChanged += new System.EventHandler(this.MuseumtenantComboBox_SelectedIndexChanged);
            // 
            // rentEnd
            // 
            this.rentEnd.Location = new System.Drawing.Point(237, 413);
            this.rentEnd.Margin = new System.Windows.Forms.Padding(4);
            this.rentEnd.Name = "rentEnd";
            this.rentEnd.Size = new System.Drawing.Size(172, 22);
            this.rentEnd.TabIndex = 65;
            this.rentEnd.ValueChanged += new System.EventHandler(this.RentEnd_ValueChanged);
            // 
            // rentStart
            // 
            this.rentStart.Location = new System.Drawing.Point(237, 380);
            this.rentStart.Margin = new System.Windows.Forms.Padding(4);
            this.rentStart.Name = "rentStart";
            this.rentStart.Size = new System.Drawing.Size(172, 22);
            this.rentStart.TabIndex = 64;
            this.rentStart.ValueChanged += new System.EventHandler(this.RentStart_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 418);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Окончание аренды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(92, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Начало аренды";
            // 
            // FilterByStartTime
            // 
            this.FilterByStartTime.AutoSize = true;
            this.FilterByStartTime.Location = new System.Drawing.Point(46, 142);
            this.FilterByStartTime.Name = "FilterByStartTime";
            this.FilterByStartTime.Size = new System.Drawing.Size(213, 21);
            this.FilterByStartTime.TabIndex = 68;
            this.FilterByStartTime.Text = "Фильтр по времени начала";
            this.FilterByStartTime.UseVisualStyleBackColor = true;
            this.FilterByStartTime.CheckedChanged += new System.EventHandler(this.FilterByStartTime_CheckedChanged);
            // 
            // FilterByEndTime
            // 
            this.FilterByEndTime.AutoSize = true;
            this.FilterByEndTime.Location = new System.Drawing.Point(34, 275);
            this.FilterByEndTime.Name = "FilterByEndTime";
            this.FilterByEndTime.Size = new System.Drawing.Size(236, 21);
            this.FilterByEndTime.TabIndex = 74;
            this.FilterByEndTime.Text = "Фильтр по времени окончания";
            this.FilterByEndTime.UseVisualStyleBackColor = true;
            this.FilterByEndTime.CheckedChanged += new System.EventHandler(this.FilterByEndTime_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "до";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 72;
            this.label6.Text = "от";
            // 
            // dateEndTo
            // 
            this.dateEndTo.Location = new System.Drawing.Point(75, 246);
            this.dateEndTo.Margin = new System.Windows.Forms.Padding(4);
            this.dateEndTo.Name = "dateEndTo";
            this.dateEndTo.Size = new System.Drawing.Size(172, 22);
            this.dateEndTo.TabIndex = 71;
            this.dateEndTo.ValueChanged += new System.EventHandler(this.DateEndTo_ValueChanged);
            // 
            // dateEndFrom
            // 
            this.dateEndFrom.Location = new System.Drawing.Point(75, 214);
            this.dateEndFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dateEndFrom.Name = "dateEndFrom";
            this.dateEndFrom.Size = new System.Drawing.Size(172, 22);
            this.dateEndFrom.TabIndex = 70;
            this.dateEndFrom.ValueChanged += new System.EventHandler(this.DateEndFrom_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "Дата окончания аренды";
            // 
            // ExhibitCombo
            // 
            this.ExhibitCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExhibitCombo.FormattingEnabled = true;
            this.ExhibitCombo.Location = new System.Drawing.Point(225, 443);
            this.ExhibitCombo.Margin = new System.Windows.Forms.Padding(4);
            this.ExhibitCombo.Name = "ExhibitCombo";
            this.ExhibitCombo.Size = new System.Drawing.Size(215, 24);
            this.ExhibitCombo.TabIndex = 77;
            this.ExhibitCombo.SelectedIndexChanged += new System.EventHandler(this.ExhibitCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 446);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "Экспонат";
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExhibitCombo);
            this.Controls.Add(this.FilterByEndTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateEndTo);
            this.Controls.Add(this.dateEndFrom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FilterByStartTime);
            this.Controls.Add(this.rentEnd);
            this.Controls.Add(this.rentStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.museumtenantComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateStartTo);
            this.Controls.Add(this.dateStartFrom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RentListBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.museumComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(515, 610);
            this.MinimumSize = new System.Drawing.Size(515, 610);
            this.Name = "Rent";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Аренда";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rent_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox RentListBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox museumComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateStartTo;
        private System.Windows.Forms.DateTimePicker dateStartFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox museumtenantComboBox;
        private System.Windows.Forms.DateTimePicker rentEnd;
        private System.Windows.Forms.DateTimePicker rentStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox FilterByStartTime;
        private System.Windows.Forms.CheckBox FilterByEndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateEndTo;
        private System.Windows.Forms.DateTimePicker dateEndFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ExhibitCombo;
        private System.Windows.Forms.Label label3;
    }
}