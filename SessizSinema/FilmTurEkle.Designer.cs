namespace SessizSinema
{
    partial class FilmTurEkle
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
            this.txtFilmTurAd = new System.Windows.Forms.TextBox();
            this.chkIndirim = new System.Windows.Forms.CheckBox();
            this.nmrIndirim = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblIndirimMiktar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIndirim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Türü Adı : ";
            // 
            // txtFilmTurAd
            // 
            this.txtFilmTurAd.Location = new System.Drawing.Point(125, 41);
            this.txtFilmTurAd.Name = "txtFilmTurAd";
            this.txtFilmTurAd.Size = new System.Drawing.Size(153, 20);
            this.txtFilmTurAd.TabIndex = 1;
            // 
            // chkIndirim
            // 
            this.chkIndirim.AutoSize = true;
            this.chkIndirim.Location = new System.Drawing.Point(126, 73);
            this.chkIndirim.Name = "chkIndirim";
            this.chkIndirim.Size = new System.Drawing.Size(56, 17);
            this.chkIndirim.TabIndex = 2;
            this.chkIndirim.Text = "İndirim";
            this.chkIndirim.UseVisualStyleBackColor = true;
            this.chkIndirim.CheckedChanged += new System.EventHandler(this.chkIndirim_CheckedChanged);
            // 
            // nmrIndirim
            // 
            this.nmrIndirim.Location = new System.Drawing.Point(126, 107);
            this.nmrIndirim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrIndirim.Name = "nmrIndirim";
            this.nmrIndirim.Size = new System.Drawing.Size(56, 20);
            this.nmrIndirim.TabIndex = 3;
            this.nmrIndirim.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrIndirim.Visible = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(126, 151);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 31);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblIndirimMiktar
            // 
            this.lblIndirimMiktar.AutoSize = true;
            this.lblIndirimMiktar.Location = new System.Drawing.Point(39, 109);
            this.lblIndirimMiktar.Name = "lblIndirimMiktar";
            this.lblIndirimMiktar.Size = new System.Drawing.Size(80, 13);
            this.lblIndirimMiktar.TabIndex = 5;
            this.lblIndirimMiktar.Text = "İndirim Miktarı : ";
            this.lblIndirimMiktar.Visible = false;
            // 
            // FilmTurEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 209);
            this.Controls.Add(this.lblIndirimMiktar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nmrIndirim);
            this.Controls.Add(this.chkIndirim);
            this.Controls.Add(this.txtFilmTurAd);
            this.Controls.Add(this.label1);
            this.Name = "FilmTurEkle";
            this.Text = "FilmTurEkle";
            ((System.ComponentModel.ISupportInitialize)(this.nmrIndirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmTurAd;
        private System.Windows.Forms.CheckBox chkIndirim;
        private System.Windows.Forms.NumericUpDown nmrIndirim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblIndirimMiktar;
    }
}