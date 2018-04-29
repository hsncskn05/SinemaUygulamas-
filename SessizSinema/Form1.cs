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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filmTürüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmTurEkle fte = new FilmTurEkle();
            fte.ShowDialog();
        }

        private void filmTürüÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmTurCikar ftc = new FilmTurCikar();
            ftc.ShowDialog();
        }

        private void filmEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmEkle fe = new FilmEkle();
            fe.ShowDialog();
        }

        private void filmÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmCikar fc = new FilmCikar();
            fc.ShowDialog();
        }

        private void biletAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletAl ba = new BiletAl();
            ba.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
