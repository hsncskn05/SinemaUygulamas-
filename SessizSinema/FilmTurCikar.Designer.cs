namespace SessizSinema
{
    partial class FilmTurCikar
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilmTuru = new System.Windows.Forms.ComboBox();
            this.btnFilmTurCikar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Türü İsmi : ";
            // 
            // cmbFilmTuru
            // 
            this.cmbFilmTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmTuru.FormattingEnabled = true;
            this.cmbFilmTuru.Location = new System.Drawing.Point(116, 63);
            this.cmbFilmTuru.Name = "cmbFilmTuru";
            this.cmbFilmTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbFilmTuru.TabIndex = 1;
            // 
            // btnFilmTurCikar
            // 
            this.btnFilmTurCikar.Location = new System.Drawing.Point(145, 101);
            this.btnFilmTurCikar.Name = "btnFilmTurCikar";
            this.btnFilmTurCikar.Size = new System.Drawing.Size(91, 47);
            this.btnFilmTurCikar.TabIndex = 2;
            this.btnFilmTurCikar.Text = "Çıkar";
            this.btnFilmTurCikar.UseVisualStyleBackColor = true;
            this.btnFilmTurCikar.Click += new System.EventHandler(this.btnFilmTurCikar_Click);
            // 
            // FilmTurCikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 230);
            this.Controls.Add(this.btnFilmTurCikar);
            this.Controls.Add(this.cmbFilmTuru);
            this.Controls.Add(this.label1);
            this.Name = "FilmTurCikar";
            this.Text = "FilmTurCikar";
            this.Load += new System.EventHandler(this.FilmTurCikar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilmTuru;
        private System.Windows.Forms.Button btnFilmTurCikar;
    }
}