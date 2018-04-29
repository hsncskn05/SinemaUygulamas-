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
    public partial class FilmTurCikar : Form
    {
        public FilmTurCikar()
        {
            InitializeComponent();
        }
        FilmTurler ft = FilmTurler.Nesne();
        private void btnFilmTurCikar_Click(object sender, EventArgs e)
        {
            ft.FilmTurlerindenCikar((FilmTur)cmbFilmTuru.SelectedItem);
            cmbFilmTuru.DataSource = ft.FilmTurleriListe();
        }

        private void FilmTurCikar_Load(object sender, EventArgs e)
        {
            
            cmbFilmTuru.DataSource = ft.FilmTurleriListe();
        }
    }
}
