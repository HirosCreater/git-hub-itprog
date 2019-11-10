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
            this.exhibitListBox = new System.Windows.Forms.ListBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.museumComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.museumtenantComboBox = new System.Windows.Forms.ComboBox();
            this.rentEnd = new System.Windows.Forms.DateTimePicker();
            this.rentStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exhibitComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(119, 409);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 23);
            this.deleteButton.TabIndex = 55;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(24, 409);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 23);
            this.addButton.TabIndex = 54;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(24, 380);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(184, 23);
            this.saveButton.TabIndex = 53;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Музей-арендатор";
            // 
            // exhibitListBox
            // 
            this.exhibitListBox.FormattingEnabled = true;
            this.exhibitListBox.Location = new System.Drawing.Point(24, 137);
            this.exhibitListBox.Name = "exhibitListBox";
            this.exhibitListBox.Size = new System.Drawing.Size(184, 225);
            this.exhibitListBox.TabIndex = 40;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(21, 15);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(39, 13);
            this.categoryLabel.TabIndex = 29;
            this.categoryLabel.Text = "Музей";
            // 
            // museumComboBox
            // 
            this.museumComboBox.FormattingEnabled = true;
            this.museumComboBox.Location = new System.Drawing.Point(87, 12);
            this.museumComboBox.Name = "museumComboBox";
            this.museumComboBox.Size = new System.Drawing.Size(121, 21);
            this.museumComboBox.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "до";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "от";
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(54, 97);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(130, 20);
            this.dateTo.TabIndex = 58;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(54, 71);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(130, 20);
            this.dateFrom.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Временной период аренд";
            // 
            // museumtenantComboBox
            // 
            this.museumtenantComboBox.FormattingEnabled = true;
            this.museumtenantComboBox.Location = new System.Drawing.Point(382, 12);
            this.museumtenantComboBox.Name = "museumtenantComboBox";
            this.museumtenantComboBox.Size = new System.Drawing.Size(162, 21);
            this.museumtenantComboBox.TabIndex = 61;
            // 
            // rentEnd
            // 
            this.rentEnd.Location = new System.Drawing.Point(414, 81);
            this.rentEnd.Name = "rentEnd";
            this.rentEnd.Size = new System.Drawing.Size(130, 20);
            this.rentEnd.TabIndex = 65;
            // 
            // rentStart
            // 
            this.rentStart.Location = new System.Drawing.Point(414, 50);
            this.rentStart.Name = "rentStart";
            this.rentStart.Size = new System.Drawing.Size(130, 20);
            this.rentStart.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Окончание аренды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(253, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Начало аренды";
            // 
            // exhibitComboBox
            // 
            this.exhibitComboBox.FormattingEnabled = true;
            this.exhibitComboBox.Location = new System.Drawing.Point(382, 115);
            this.exhibitComboBox.Name = "exhibitComboBox";
            this.exhibitComboBox.Size = new System.Drawing.Size(162, 21);
            this.exhibitComboBox.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Выбор экспоната";
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 560);
            this.Controls.Add(this.exhibitComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rentEnd);
            this.Controls.Add(this.rentStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.museumtenantComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exhibitListBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.museumComboBox);
            this.Name = "Rent";
            this.Text = "Аренда";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox exhibitListBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox museumComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox museumtenantComboBox;
        private System.Windows.Forms.DateTimePicker rentEnd;
        private System.Windows.Forms.DateTimePicker rentStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox exhibitComboBox;
        private System.Windows.Forms.Label label3;
    }
}