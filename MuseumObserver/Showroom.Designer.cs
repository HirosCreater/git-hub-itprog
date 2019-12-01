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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.showroomListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Название зала";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Выбор зала";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(13, 303);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(358, 22);
            this.nameTextBox.TabIndex = 36;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(195, 365);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(176, 28);
            this.deleteButton.TabIndex = 35;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 365);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(176, 28);
            this.addButton.TabIndex = 34;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(13, 331);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(358, 28);
            this.saveButton.TabIndex = 33;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showroomListBox
            // 
            this.showroomListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showroomListBox.FormattingEnabled = true;
            this.showroomListBox.ItemHeight = 16;
            this.showroomListBox.Location = new System.Drawing.Point(13, 30);
            this.showroomListBox.Margin = new System.Windows.Forms.Padding(4);
            this.showroomListBox.Name = "showroomListBox";
            this.showroomListBox.Size = new System.Drawing.Size(358, 244);
            this.showroomListBox.TabIndex = 39;
            this.showroomListBox.SelectedIndexChanged += new System.EventHandler(this.showroomListBox_SelectedIndexChanged);
            // 
            // Showroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.showroomListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(400, 900);
            this.MinimumSize = new System.Drawing.Size(400, 455);
            this.Name = "Showroom";
            this.Text = "Выставочные залы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox showroomListBox;
    }
}