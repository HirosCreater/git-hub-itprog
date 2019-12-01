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
            this.deleteButton.Location = new System.Drawing.Point(159, 503);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(119, 28);
            this.deleteButton.TabIndex = 55;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(32, 503);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 28);
            this.addButton.TabIndex = 54;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(32, 468);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(245, 28);
            this.saveButton.TabIndex = 53;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Музей-арендатор";
            // 
            // exhibitListBox
            // 
            this.exhibitListBox.FormattingEnabled = true;
            this.exhibitListBox.ItemHeight = 16;
            this.exhibitListBox.Location = new System.Drawing.Point(32, 169);
            this.exhibitListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exhibitListBox.Name = "exhibitListBox";
            this.exhibitListBox.Size = new System.Drawing.Size(244, 276);
            this.exhibitListBox.TabIndex = 40;
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
            this.museumComboBox.FormattingEnabled = true;
            this.museumComboBox.Location = new System.Drawing.Point(116, 15);
            this.museumComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.museumComboBox.Name = "museumComboBox";
            this.museumComboBox.Size = new System.Drawing.Size(160, 24);
            this.museumComboBox.TabIndex = 28;
            this.museumComboBox.SelectedIndexChanged += new System.EventHandler(this.museumComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "до";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 87);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 59;
            this.label11.Text = "от";
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(72, 119);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(172, 22);
            this.dateTo.TabIndex = 58;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(72, 87);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(172, 22);
            this.dateFrom.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 17);
            this.label12.TabIndex = 56;
            this.label12.Text = "Временной период аренд";
            // 
            // museumtenantComboBox
            // 
            this.museumtenantComboBox.FormattingEnabled = true;
            this.museumtenantComboBox.Location = new System.Drawing.Point(509, 15);
            this.museumtenantComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.museumtenantComboBox.Name = "museumtenantComboBox";
            this.museumtenantComboBox.Size = new System.Drawing.Size(215, 24);
            this.museumtenantComboBox.TabIndex = 61;
            // 
            // rentEnd
            // 
            this.rentEnd.Location = new System.Drawing.Point(552, 100);
            this.rentEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rentEnd.Name = "rentEnd";
            this.rentEnd.Size = new System.Drawing.Size(172, 22);
            this.rentEnd.TabIndex = 65;
            // 
            // rentStart
            // 
            this.rentStart.Location = new System.Drawing.Point(552, 62);
            this.rentStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rentStart.Name = "rentStart";
            this.rentStart.Size = new System.Drawing.Size(172, 22);
            this.rentStart.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 100);
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
            this.label2.Location = new System.Drawing.Point(337, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Начало аренды";
            // 
            // exhibitComboBox
            // 
            this.exhibitComboBox.FormattingEnabled = true;
            this.exhibitComboBox.Location = new System.Drawing.Point(509, 142);
            this.exhibitComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exhibitComboBox.Name = "exhibitComboBox";
            this.exhibitComboBox.Size = new System.Drawing.Size(215, 24);
            this.exhibitComboBox.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Выбор экспоната";
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 689);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Rent";
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