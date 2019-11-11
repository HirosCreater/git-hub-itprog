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
            this.MaecenasListBox = new System.Windows.Forms.ListBox();
            this.ChangeMaecenas = new System.Windows.Forms.Button();
            this.AddMaecenas = new System.Windows.Forms.Button();
            this.DeleteMaecenas = new System.Windows.Forms.Button();
            this.NameMaecenas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MaecenasListBox
            // 
            this.MaecenasListBox.FormattingEnabled = true;
            this.MaecenasListBox.ItemHeight = 16;
            this.MaecenasListBox.Location = new System.Drawing.Point(16, 34);
            this.MaecenasListBox.Margin = new System.Windows.Forms.Padding(4);
            this.MaecenasListBox.Name = "MaecenasListBox";
            this.MaecenasListBox.Size = new System.Drawing.Size(244, 244);
            this.MaecenasListBox.TabIndex = 13;
            this.MaecenasListBox.SelectedIndexChanged += new System.EventHandler(this.MaecenasListBox_SelectedIndexChanged);
            // 
            // ChangeMaecenas
            // 
            this.ChangeMaecenas.Location = new System.Drawing.Point(269, 66);
            this.ChangeMaecenas.Name = "ChangeMaecenas";
            this.ChangeMaecenas.Size = new System.Drawing.Size(248, 28);
            this.ChangeMaecenas.TabIndex = 1;
            this.ChangeMaecenas.Text = "Сохранить изменения";
            this.ChangeMaecenas.UseVisualStyleBackColor = true;
            this.ChangeMaecenas.Click += new System.EventHandler(this.ChangeMaecenas_Click);
            // 
            // AddMaecenas
            // 
            this.AddMaecenas.Location = new System.Drawing.Point(269, 102);
            this.AddMaecenas.Name = "AddMaecenas";
            this.AddMaecenas.Size = new System.Drawing.Size(119, 28);
            this.AddMaecenas.TabIndex = 2;
            this.AddMaecenas.Text = "Добавить";
            this.AddMaecenas.UseVisualStyleBackColor = true;
            this.AddMaecenas.Click += new System.EventHandler(this.AddMaecenas_Click);
            // 
            // DeleteMaecenas
            // 
            this.DeleteMaecenas.Location = new System.Drawing.Point(398, 102);
            this.DeleteMaecenas.Name = "DeleteMaecenas";
            this.DeleteMaecenas.Size = new System.Drawing.Size(119, 28);
            this.DeleteMaecenas.TabIndex = 3;
            this.DeleteMaecenas.Text = "Удалить";
            this.DeleteMaecenas.UseVisualStyleBackColor = true;
            this.DeleteMaecenas.Click += new System.EventHandler(this.DeleteMaecenas_Click);
            // 
            // NameMaecenas
            // 
            this.NameMaecenas.Location = new System.Drawing.Point(269, 34);
            this.NameMaecenas.Name = "NameMaecenas";
            this.NameMaecenas.Size = new System.Drawing.Size(248, 22);
            this.NameMaecenas.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выбор мецената";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя мецената";
            // 
            // Maecenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 308);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameMaecenas);
            this.Controls.Add(this.DeleteMaecenas);
            this.Controls.Add(this.AddMaecenas);
            this.Controls.Add(this.ChangeMaecenas);
            this.Controls.Add(this.MaecenasListBox);
            this.Name = "Maecenas";
            this.Text = "Меценаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MaecenasListBox;
        private System.Windows.Forms.Button ChangeMaecenas;
        private System.Windows.Forms.Button AddMaecenas;
        private System.Windows.Forms.Button DeleteMaecenas;
        private System.Windows.Forms.TextBox NameMaecenas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}