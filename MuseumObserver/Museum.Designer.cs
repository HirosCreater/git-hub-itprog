namespace MuseumObserver
{
    partial class Museum
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
            this.NameMuseum = new System.Windows.Forms.TextBox();
            this.DeleteMuseum = new System.Windows.Forms.Button();
            this.AddMuseum = new System.Windows.Forms.Button();
            this.ChangeMuseum = new System.Windows.Forms.Button();
            this.MuseumListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Название музея";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Выбор музея";
            // 
            // NameMuseum
            // 
            this.NameMuseum.Location = new System.Drawing.Point(265, 32);
            this.NameMuseum.Name = "NameMuseum";
            this.NameMuseum.Size = new System.Drawing.Size(248, 22);
            this.NameMuseum.TabIndex = 17;
            // 
            // DeleteMuseum
            // 
            this.DeleteMuseum.Location = new System.Drawing.Point(394, 100);
            this.DeleteMuseum.Name = "DeleteMuseum";
            this.DeleteMuseum.Size = new System.Drawing.Size(119, 28);
            this.DeleteMuseum.TabIndex = 16;
            this.DeleteMuseum.Text = "Удалить";
            this.DeleteMuseum.UseVisualStyleBackColor = true;
            this.DeleteMuseum.Click += new System.EventHandler(this.DeleteMuseum_Click);
            // 
            // AddMuseum
            // 
            this.AddMuseum.Location = new System.Drawing.Point(265, 100);
            this.AddMuseum.Name = "AddMuseum";
            this.AddMuseum.Size = new System.Drawing.Size(119, 28);
            this.AddMuseum.TabIndex = 15;
            this.AddMuseum.Text = "Добавить";
            this.AddMuseum.UseVisualStyleBackColor = true;
            this.AddMuseum.Click += new System.EventHandler(this.AddMuseum_Click);
            // 
            // ChangeMuseum
            // 
            this.ChangeMuseum.Location = new System.Drawing.Point(265, 64);
            this.ChangeMuseum.Name = "ChangeMuseum";
            this.ChangeMuseum.Size = new System.Drawing.Size(248, 28);
            this.ChangeMuseum.TabIndex = 14;
            this.ChangeMuseum.Text = "Сохранить изменения";
            this.ChangeMuseum.UseVisualStyleBackColor = true;
            this.ChangeMuseum.Click += new System.EventHandler(this.ChangeMuseum_Click);
            // 
            // MuseumListBox
            // 
            this.MuseumListBox.FormattingEnabled = true;
            this.MuseumListBox.ItemHeight = 16;
            this.MuseumListBox.Location = new System.Drawing.Point(12, 32);
            this.MuseumListBox.Margin = new System.Windows.Forms.Padding(4);
            this.MuseumListBox.Name = "MuseumListBox";
            this.MuseumListBox.Size = new System.Drawing.Size(244, 244);
            this.MuseumListBox.TabIndex = 20;
            this.MuseumListBox.SelectedIndexChanged += new System.EventHandler(this.MuseumListBox_SelectedIndexChanged);
            // 
            // Museum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 308);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameMuseum);
            this.Controls.Add(this.DeleteMuseum);
            this.Controls.Add(this.AddMuseum);
            this.Controls.Add(this.ChangeMuseum);
            this.Controls.Add(this.MuseumListBox);
            this.Name = "Museum";
            this.Text = "Museum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameMuseum;
        private System.Windows.Forms.Button DeleteMuseum;
        private System.Windows.Forms.Button AddMuseum;
        private System.Windows.Forms.Button ChangeMuseum;
        private System.Windows.Forms.ListBox MuseumListBox;
    }
}