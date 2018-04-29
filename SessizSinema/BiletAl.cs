using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessizSinema
{
    public partial class BiletAl : Form
    {
        public BiletAl()
        {
            InitializeComponent();
        }
        
        double haftaici = 10;
        double haftasonu = 15;

        Biletler b = Biletler.Nesne();
        Filmler filmler = Filmler.Nesne();
        private void BiletAl_Load(object sender, EventArgs e)
        {
            cmbFilm.DataSource = filmler.FilmlerListe();

            if (cmbFilm.Items.Count == 0)
	        {
                MessageBox.Show("Film Bulunmamaktadır.");
                btnBiletOlustur.Enabled = false;
                btnBiletYazdir.Enabled = false;
	        }
            lblBiletNo.Text = Convert.ToString(b.BiletNoHesapla());
        }
        
        private void btnBiletOlustur_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Bilet Fiyatınız : " + FiyatOlustur().ToString());
        }

        private void btnBiletYazdir_Click(object sender, EventArgs e)
        {
            Bilet bilet = new Bilet();
            bilet.BiletOlustur(Convert.ToInt32(lblBiletNo.Text),FiyatOlustur(),((Film)(cmbFilm.SelectedValue)));
            b.BiletlereEkle(bilet);
            MessageBox.Show("Biletiniz Oluşturulmuştur.");
            lblBiletNo.Text = Convert.ToString(b.BiletNoHesapla());
            
            cmbFilm.SelectedIndex = 0;
            dtpTarihSecim.Value = DateTime.Now;
            nmrKisi.Value = 1;
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpTarihSecim.MinDate = ((Film)(cmbFilm.SelectedValue)).TarihDondur();
        }

        public double FiyatOlustur()
        {
            double fiyat=0;
            if (dtpTarihSecim.Value.DayOfWeek.ToString() == "Saturday" || dtpTarihSecim.Value.DayOfWeek.ToString() == "Sunday")
            {
                fiyat = (int)nmrKisi.Value * ((haftasonu *(100 - ((Film)(cmbFilm.SelectedValue)).IndirimOrani()))/100);
                
            }
            else 
            {
                fiyat = (int)nmrKisi.Value * ((haftaici * (100 - ((Film)(cmbFilm.SelectedValue)).IndirimOrani())) / 100);
            }
            return fiyat;
        }
    }
}
