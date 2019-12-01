namespace MuseumObserver
{
    partial class Exhibition
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
            this.exhibitionListBox = new System.Windows.Forms.ListBox();
            this.exhibitListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exhibitionListBox
            // 
            this.exhibitionListBox.FormattingEnabled = true;
            this.exhibitionListBox.ItemHeight = 16;
            this.exhibitionListBox.Location = new System.Drawing.Point(313, 15);
            this.exhibitionListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exhibitionListBox.Name = "exhibitionListBox";
            this.exhibitionListBox.Size = new System.Drawing.Size(257, 276);
            this.exhibitionListBox.TabIndex = 0;
            this.exhibitionListBox.SelectedIndexChanged += new System.EventHandler(this.exhibitionListBox_SelectedIndexChanged);
            // 
            // exhibitListBox
            // 
            this.exhibitListBox.FormattingEnabled = true;
            this.exhibitListBox.ItemHeight = 16;
            this.exhibitListBox.Location = new System.Drawing.Point(623, 15);
            this.exhibitListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exhibitListBox.Name = "exhibitListBox";
            this.exhibitListBox.Size = new System.Drawing.Size(188, 276);
            this.exhibitListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Временной период выставок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "от";
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(87, 78);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(172, 22);
            this.dateTo.TabIndex = 13;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(87, 46);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(172, 22);
            this.dateFrom.TabIndex = 12;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(55, 145);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 22);
            this.nameTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Название выставки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "окончание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "начало";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(99, 258);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(172, 22);
            this.endDate.TabIndex = 21;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(99, 226);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(172, 22);
            this.startDate.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Дата проведения выставки";
            // 
            // Exhibition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exhibitListBox);
            this.Controls.Add(this.exhibitionListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Exhibition";
            this.Text = "Выставки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exhibition_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox exhibitionListBox;
        private System.Windows.Forms.ListBox exhibitListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label7;
    }
}