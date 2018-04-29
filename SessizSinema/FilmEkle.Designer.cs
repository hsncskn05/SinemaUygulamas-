namespace SessizSinema
{
    partial class FilmEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.chkIndirim = new System.Windows.Forms.CheckBox();
            this.dtpVizyon = new System.Windows.Forms.DateTimePicker();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.nmrIndirim = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilmTuru = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIndirim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Türü : ";
            // 
            // chkIndirim
            // 
            this.chkIndirim.AutoSize = true;
            this.chkIndirim.Location = new System.Drawing.Point(106, 115);
            this.chkIndirim.Name = "chkIndirim";
            this.chkIndirim.Size = new System.Drawing.Size(56, 17);
            this.chkIndirim.TabIndex = 2;
            this.chkIndirim.Text = "İndirim";
            this.chkIndirim.UseVisualStyleBackColor = true;
            this.chkIndirim.CheckedChanged += new System.EventHandler(this.chkIndirim_CheckedChanged);
            // 
            // dtpVizyon
            // 
            this.dtpVizyon.Location = new System.Drawing.Point(106, 158);
            this.dtpVizyon.Name = "dtpVizyon";
            this.dtpVizyon.Size = new System.Drawing.Size(190, 20);
            this.dtpVizyon.TabIndex = 4;
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(107, 50);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(189, 20);
            this.txtFilmAd.TabIndex = 6;
            // 
            // nmrIndirim
            // 
            this.nmrIndirim.Location = new System.Drawing.Point(168, 114);
            this.nmrIndirim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrIndirim.Name = "nmrIndirim";
            this.nmrIndirim.Size = new System.Drawing.Size(128, 20);
            this.nmrIndirim.TabIndex = 7;
            this.nmrIndirim.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrIndirim.Visible = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(208, 198);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 38);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vizyon Tarihi :";
            // 
            // cmbFilmTuru
            // 
            this.cmbFilmTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmTuru.FormattingEnabled = true;
            this.cmbFilmTuru.Location = new System.Drawing.Point(107, 79);
            this.cmbFilmTuru.Name = "cmbFilmTuru";
            this.cmbFilmTuru.Size = new System.Drawing.Size(189, 21);
            this.cmbFilmTuru.TabIndex = 10;
            // 
            // FilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 318);
            this.Controls.Add(this.cmbFilmTuru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nmrIndirim);
            this.Controls.Add(this.txtFilmAd);
            this.Controls.Add(this.dtpVizyon);
            this.Controls.Add(this.chkIndirim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FilmEkle";
            this.Text = "FilmEkle";
            this.Load += new System.EventHandler(this.FilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrIndirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIndirim;
        private System.Windows.Forms.DateTimePicker dtpVizyon;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.NumericUpDown nmrIndirim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilmTuru;
    }
}