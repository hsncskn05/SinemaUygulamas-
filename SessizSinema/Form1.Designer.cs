namespace SessizSinema
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.biletAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmÇıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmTürüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmTürüEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmTürüÇıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletAlToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.filmTürüToolStripMenuItem,
            this.satışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // biletAlToolStripMenuItem
            // 
            this.biletAlToolStripMenuItem.Name = "biletAlToolStripMenuItem";
            this.biletAlToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.biletAlToolStripMenuItem.Text = "Bilet Al";
            this.biletAlToolStripMenuItem.Click += new System.EventHandler(this.biletAlToolStripMenuItem_Click);
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmEkleToolStripMenuItem,
            this.filmÇıkarToolStripMenuItem});
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filmToolStripMenuItem.Text = "Film";
            // 
            // filmEkleToolStripMenuItem
            // 
            this.filmEkleToolStripMenuItem.Name = "filmEkleToolStripMenuItem";
            this.filmEkleToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.filmEkleToolStripMenuItem.Text = "Film Ekle";
            this.filmEkleToolStripMenuItem.Click += new System.EventHandler(this.filmEkleToolStripMenuItem_Click);
            // 
            // filmÇıkarToolStripMenuItem
            // 
            this.filmÇıkarToolStripMenuItem.Name = "filmÇıkarToolStripMenuItem";
            this.filmÇıkarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.filmÇıkarToolStripMenuItem.Text = "Film Çıkar";
            this.filmÇıkarToolStripMenuItem.Click += new System.EventHandler(this.filmÇıkarToolStripMenuItem_Click);
            // 
            // filmTürüToolStripMenuItem
            // 
            this.filmTürüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmTürüEkleToolStripMenuItem,
            this.filmTürüÇıkarToolStripMenuItem});
            this.filmTürüToolStripMenuItem.Name = "filmTürüToolStripMenuItem";
            this.filmTürüToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.filmTürüToolStripMenuItem.Text = "Film Türü";
            // 
            // filmTürüEkleToolStripMenuItem
            // 
            this.filmTürüEkleToolStripMenuItem.Name = "filmTürüEkleToolStripMenuItem";
            this.filmTürüEkleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.filmTürüEkleToolStripMenuItem.Text = "Film Türü Ekle";
            this.filmTürüEkleToolStripMenuItem.Click += new System.EventHandler(this.filmTürüEkleToolStripMenuItem_Click);
            // 
            // filmTürüÇıkarToolStripMenuItem
            // 
            this.filmTürüÇıkarToolStripMenuItem.Name = "filmTürüÇıkarToolStripMenuItem";
            this.filmTürüÇıkarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.filmTürüÇıkarToolStripMenuItem.Text = "Film Türü Çıkar";
            this.filmTürüÇıkarToolStripMenuItem.Click += new System.EventHandler(this.filmTürüÇıkarToolStripMenuItem_Click);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.satışToolStripMenuItem.Text = "Satış Raporu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 443);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem biletAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmÇıkarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmTürüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmTürüEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmTürüÇıkarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
    }
}

