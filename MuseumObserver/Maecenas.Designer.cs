namespace MuseumObserver
{
    partial class Maecenas
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
            this.NameMaecenas = new System.Windows.Forms.TextBox();
            this.DeleteMaecenas = new System.Windows.Forms.Button();
            this.AddMaecenas = new System.Windows.Forms.Button();
            this.ChangeMaecenas = new System.Windows.Forms.Button();
            this.MaecenasListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Имя мецената";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Выбор мецената";
            // 
            // NameMaecenas
            // 
            this.NameMaecenas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameMaecenas.Location = new System.Drawing.Point(13, 303);
            this.NameMaecenas.Name = "NameMaecenas";
            this.NameMaecenas.Size = new System.Drawing.Size(358, 22);
            this.NameMaecenas.TabIndex = 24;
            // 
            // DeleteMaecenas
            // 
            this.DeleteMaecenas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteMaecenas.Location = new System.Drawing.Point(195, 365);
            this.DeleteMaecenas.Name = "DeleteMaecenas";
            this.DeleteMaecenas.Size = new System.Drawing.Size(176, 28);
            this.DeleteMaecenas.TabIndex = 23;
            this.DeleteMaecenas.Text = "Удалить";
            this.DeleteMaecenas.UseVisualStyleBackColor = true;
            this.DeleteMaecenas.Click += new System.EventHandler(this.DeleteMaecenas_Click);
            // 
            // AddMaecenas
            // 
            this.AddMaecenas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMaecenas.Location = new System.Drawing.Point(13, 365);
            this.AddMaecenas.Name = "AddMaecenas";
            this.AddMaecenas.Size = new System.Drawing.Size(176, 28);
            this.AddMaecenas.TabIndex = 22;
            this.AddMaecenas.Text = "Добавить";
            this.AddMaecenas.UseVisualStyleBackColor = true;
            this.AddMaecenas.Click += new System.EventHandler(this.AddMaecenas_Click);
            // 
            // ChangeMaecenas
            // 
            this.ChangeMaecenas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeMaecenas.Location = new System.Drawing.Point(13, 331);
            this.ChangeMaecenas.Name = "ChangeMaecenas";
            this.ChangeMaecenas.Size = new System.Drawing.Size(358, 28);
            this.ChangeMaecenas.TabIndex = 21;
            this.ChangeMaecenas.Text = "Сохранить изменения";
            this.ChangeMaecenas.UseVisualStyleBackColor = true;
            this.ChangeMaecenas.Click += new System.EventHandler(this.ChangeMaecenas_Click);
            // 
            // MaecenasListBox
            // 
            this.MaecenasListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaecenasListBox.FormattingEnabled = true;
            this.MaecenasListBox.ItemHeight = 16;
            this.MaecenasListBox.Location = new System.Drawing.Point(13, 30);
            this.MaecenasListBox.Margin = new System.Windows.Forms.Padding(4);
            this.MaecenasListBox.Name = "MaecenasListBox";
            this.MaecenasListBox.Size = new System.Drawing.Size(358, 244);
            this.MaecenasListBox.TabIndex = 27;
            this.MaecenasListBox.SelectedIndexChanged += new System.EventHandler(this.MaecenasListBox_SelectedIndexChanged);
            // 
            // Maecenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameMaecenas);
            this.Controls.Add(this.DeleteMaecenas);
            this.Controls.Add(this.AddMaecenas);
            this.Controls.Add(this.ChangeMaecenas);
            this.Controls.Add(this.MaecenasListBox);
            this.MaximumSize = new System.Drawing.Size(400, 900);
            this.MinimumSize = new System.Drawing.Size(400, 455);
            this.Name = "Maecenas";
            this.Text = "Меценаты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Maecenas_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameMaecenas;
        private System.Windows.Forms.Button DeleteMaecenas;
        private System.Windows.Forms.Button AddMaecenas;
        private System.Windows.Forms.Button ChangeMaecenas;
        private System.Windows.Forms.ListBox MaecenasListBox;
    }
}