using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessizSinema
{
    class Bilet
    {
        private int _biletno;
        private double _biletfiyat;
        private Film _film;

        public void BiletOlustur(int biletno, double biletfiyat, Film film) 
        {
            _biletno = biletno;
            _biletfiyat = biletfiyat;
            _film = film;

        }

    }
}
