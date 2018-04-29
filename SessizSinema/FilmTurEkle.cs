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
    public partial class FilmTurEkle : Form
    {
        public FilmTurEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FilmTurler fturler = FilmTurler.Nesne();
            FilmTur ft = new FilmTur();
            if (chkIndirim.Checked)
            {
                ft.FilmTurEkle(txtFilmTurAd.Text, (int)nmrIndirim.Value);
            }
            else
            {
                ft.FilmTurEkle(txtFilmTurAd.Text);
            }
            MessageBox.Show("Film Türü Eklendi");
            fturler.FilmTurlerineEkle(ft);

            txtFilmTurAd.Text = string.Empty;
            chkIndirim.Checked = false;
        }

        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndirim.Checked)
            {
                lblIndirimMiktar.Visible = true;
                nmrIndirim.Visible = true;
            }
            else
            {
                lblIndirimMiktar.Visible = false;
                nmrIndirim.Visible = false;
            }
        }
    }
}
