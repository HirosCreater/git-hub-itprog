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
            this.SuspendLayout();
            // 
            // exhibitionListBox
            // 
            this.exhibitionListBox.FormattingEnabled = true;
            this.exhibitionListBox.Location = new System.Drawing.Point(38, 12);
            this.exhibitionListBox.Name = "exhibitionListBox";
            this.exhibitionListBox.Size = new System.Drawing.Size(194, 225);
            this.exhibitionListBox.TabIndex = 0;
            this.exhibitionListBox.SelectedIndexChanged += new System.EventHandler(this.exhibitionListBox_SelectedIndexChanged);
            // 
            // exhibitListBox
            // 
            this.exhibitListBox.FormattingEnabled = true;
            this.exhibitListBox.Location = new System.Drawing.Point(272, 12);
            this.exhibitListBox.Name = "exhibitListBox";
            this.exhibitListBox.Size = new System.Drawing.Size(142, 225);
            this.exhibitListBox.TabIndex = 1;
            // 
            // Exhibition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 322);
            this.Controls.Add(this.exhibitListBox);
            this.Controls.Add(this.exhibitionListBox);
            this.Name = "Exhibition";
            this.Text = "Выставки";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox exhibitionListBox;
        private System.Windows.Forms.ListBox exhibitListBox;
    }
}