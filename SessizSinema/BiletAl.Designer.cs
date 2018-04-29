namespace SessizSinema
{
    partial class BiletAl
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.dtpTarihSecim = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBiletNo = new System.Windows.Forms.Label();
            this.nmrKisi = new System.Windows.Forms.NumericUpDown();
            this.btnBiletOlustur = new System.Windows.Forms.Button();
            this.btnBiletYazdir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kişi Sayısı : ";
            // 
            // cmbFilm
            // 
            this.cmbFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(98, 51);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(152, 21);
            this.cmbFilm.TabIndex = 3;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            // 
            // dtpTarihSecim
            // 
            this.dtpTarihSecim.Location = new System.Drawing.Point(98, 85);
            this.dtpTarihSecim.Name = "dtpTarihSecim";
            this.dtpTarihSecim.Size = new System.Drawing.Size(152, 20);
            this.dtpTarihSecim.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bilet No : ";
            // 
            // lblBiletNo
            // 
            this.lblBiletNo.AutoSize = true;
            this.lblBiletNo.Location = new System.Drawing.Point(98, 162);
            this.lblBiletNo.Name = "lblBiletNo";
            this.lblBiletNo.Size = new System.Drawing.Size(0, 13);
            this.lblBiletNo.TabIndex = 6;
            // 
            // nmrKisi
            // 
            this.nmrKisi.Location = new System.Drawing.Point(101, 124);
            this.nmrKisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrKisi.Name = "nmrKisi";
            this.nmrKisi.Size = new System.Drawing.Size(75, 20);
            this.nmrKisi.TabIndex = 7;
            this.nmrKisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBiletOlustur
            // 
            this.btnBiletOlustur.Location = new System.Drawing.Point(98, 206);
            this.btnBiletOlustur.Name = "btnBiletOlustur";
            this.btnBiletOlustur.Size = new System.Drawing.Size(98, 39);
            this.btnBiletOlustur.TabIndex = 8;
            this.btnBiletOlustur.Text = "Bilet Oluştur";
            this.btnBiletOlustur.UseVisualStyleBackColor = true;
            this.btnBiletOlustur.Click += new System.EventHandler(this.btnBiletOlustur_Click);
            // 
            // btnBiletYazdir
            // 
            this.btnBiletYazdir.Location = new System.Drawing.Point(202, 206);
            this.btnBiletYazdir.Name = "btnBiletYazdir";
            this.btnBiletYazdir.Size = new System.Drawing.Size(98, 39);
            this.btnBiletYazdir.TabIndex = 9;
            this.btnBiletYazdir.Text = "Bilet Yazdır";
            this.btnBiletYazdir.UseVisualStyleBackColor = true;
            this.btnBiletYazdir.Click += new System.EventHandler(this.btnBiletYazdir_Click);
            // 
            // BiletAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 342);
            this.Controls.Add(this.btnBiletYazdir);
            this.Controls.Add(this.btnBiletOlustur);
            this.Controls.Add(this.nmrKisi);
            this.Controls.Add(this.lblBiletNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTarihSecim);
            this.Controls.Add(this.cmbFilm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BiletAl";
            this.Text = "BiletAl";
            this.Load += new System.EventHandler(this.BiletAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrKisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.DateTimePicker dtpTarihSecim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBiletNo;
        private System.Windows.Forms.NumericUpDown nmrKisi;
        private System.Windows.Forms.Button btnBiletOlustur;
        private System.Windows.Forms.Button btnBiletYazdir;
    }
}