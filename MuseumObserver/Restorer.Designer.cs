namespace MuseumObserver
{
    partial class Restorer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteRestorer = new System.Windows.Forms.Button();
            this.AddRestorer = new System.Windows.Forms.Button();
            this.ChangeRestorer = new System.Windows.Forms.Button();
            this.RestorerListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ф.И.О. реставратора";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Выбор реставратора";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(12, 306);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(358, 22);
            this.nameTextBox.TabIndex = 31;
            // 
            // DeleteRestorer
            // 
            this.DeleteRestorer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteRestorer.Location = new System.Drawing.Point(194, 368);
            this.DeleteRestorer.Name = "DeleteRestorer";
            this.DeleteRestorer.Size = new System.Drawing.Size(176, 28);
            this.DeleteRestorer.TabIndex = 30;
            this.DeleteRestorer.Text = "Удалить";
            this.DeleteRestorer.UseVisualStyleBackColor = true;
            this.DeleteRestorer.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AddRestorer
            // 
            this.AddRestorer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRestorer.Location = new System.Drawing.Point(12, 368);
            this.AddRestorer.Name = "AddRestorer";
            this.AddRestorer.Size = new System.Drawing.Size(176, 28);
            this.AddRestorer.TabIndex = 29;
            this.AddRestorer.Text = "Добавить";
            this.AddRestorer.UseVisualStyleBackColor = true;
            this.AddRestorer.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ChangeRestorer
            // 
            this.ChangeRestorer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeRestorer.Enabled = false;
            this.ChangeRestorer.Location = new System.Drawing.Point(12, 334);
            this.ChangeRestorer.Name = "ChangeRestorer";
            this.ChangeRestorer.Size = new System.Drawing.Size(358, 28);
            this.ChangeRestorer.TabIndex = 28;
            this.ChangeRestorer.Text = "Сохранить изменения";
            this.ChangeRestorer.UseVisualStyleBackColor = true;
            this.ChangeRestorer.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // RestorerListBox
            // 
            this.RestorerListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestorerListBox.FormattingEnabled = true;
            this.RestorerListBox.ItemHeight = 16;
            this.RestorerListBox.Location = new System.Drawing.Point(12, 33);
            this.RestorerListBox.Margin = new System.Windows.Forms.Padding(4);
            this.RestorerListBox.Name = "RestorerListBox";
            this.RestorerListBox.Size = new System.Drawing.Size(358, 244);
            this.RestorerListBox.TabIndex = 34;
            this.RestorerListBox.SelectedIndexChanged += new System.EventHandler(this.RestorerListBox_SelectedIndexChanged);
            // 
            // Restorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.DeleteRestorer);
            this.Controls.Add(this.AddRestorer);
            this.Controls.Add(this.ChangeRestorer);
            this.Controls.Add(this.RestorerListBox);
            this.MinimumSize = new System.Drawing.Size(400, 455);
            this.Name = "Restorer";
            this.Text = "Restorer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Restorer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button DeleteRestorer;
        private System.Windows.Forms.Button AddRestorer;
        private System.Windows.Forms.Button ChangeRestorer;
        private System.Windows.Forms.ListBox RestorerListBox;
    }
}