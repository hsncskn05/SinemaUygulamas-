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
    public partial class FilmCikar : Form
    {
        public FilmCikar()
        {
            InitializeComponent();
        }
        Filmler ft = Filmler.Nesne();
        private void FilmCikar_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ft.FilmlerListe();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            ft.FilmlerdenCikar((Film)comboBox1.SelectedItem);
        }
    }
}
