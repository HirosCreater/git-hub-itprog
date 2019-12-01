namespace MuseumObserver
{
    partial class Showroom
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
            this.showroomListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showroomListBox
            // 
            this.showroomListBox.FormattingEnabled = true;
            this.showroomListBox.ItemHeight = 16;
            this.showroomListBox.Location = new System.Drawing.Point(16, 34);
            this.showroomListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showroomListBox.Name = "showroomListBox";
            this.showroomListBox.Size = new System.Drawing.Size(244, 244);
            this.showroomListBox.TabIndex = 13;
            this.showroomListBox.SelectedIndexChanged += new System.EventHandler(this.showroomListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выбор зала";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(395, 102);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(119, 28);
            this.deleteButton.TabIndex = 30;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(269, 102);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 28);
            this.addButton.TabIndex = 29;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(269, 66);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(245, 28);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Название зала";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(269, 34);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(244, 22);
            this.nameTextBox.TabIndex = 32;
            // 
            // Showroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 308);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showroomListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Showroom";
            this.Text = "Выставочные залы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Showroom_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox showroomListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}