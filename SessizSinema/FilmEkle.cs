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
    public partial class FilmEkle : Form
    {
        public FilmEkle()
        {
            InitializeComponent();
        }

        private void FilmEkle_Load(object sender, EventArgs e)
        {
            FilmTurler fturler = FilmTurler.Nesne();
            cmbFilmTuru.DataSource = fturler.FilmTurleriListe();
            dtpVizyon.MinDate = DateTime.Today;

            if (cmbFilmTuru.Items.Count==0)
            {
                MessageBox.Show("Film Türü Bulunmamaktadır.Film Türü Ekleyiniz.");
                btnEkle.Enabled = false;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Filmler filmler = Filmler.Nesne();
            Film film = new Film();
            if (txtFilmAd.Text!="")
            {
                if (chkIndirim.Checked)
                {
                    film.FilmEkle(txtFilmAd.Text, (int)nmrIndirim.Value, (FilmTur)cmbFilmTuru.SelectedItem, dtpVizyon.Value);
                }
                else
                {
                    film.FilmEkle(txtFilmAd.Text, (FilmTur)cmbFilmTuru.SelectedItem, dtpVizyon.Value);

                }
                MessageBox.Show("Film Eklendi");
                filmler.FilmlereEkle(film);
            }
            else
            {
                MessageBox.Show("Lütfen Film Adı Giriniz..");
            }

            txtFilmAd.Text = string.Empty;
            chkIndirim.Checked = false;
            dtpVizyon.Value = DateTime.Today;
            cmbFilmTuru.SelectedIndex = 0;
        }

        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndirim.Checked)
            {
                nmrIndirim.Visible = true;
            }
            else
            {
                nmrIndirim.Visible = false;
            }
        }

        
    }
}
