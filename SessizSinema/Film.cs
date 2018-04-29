using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessizSinema
{
    class Film
    {
        private string _filmAd;
        private int _indirim;
        private FilmTur _filmTur;
        private DateTime _vizyonTarih;

        public void FilmEkle(string filmAd, FilmTur filmTur, DateTime vizyon)
        {
            _filmAd = filmAd;
            _indirim = 0;
            _filmTur = filmTur;
            _vizyonTarih = vizyon;
        }

        public void FilmEkle(string filmAd,int indirim, FilmTur filmTur, DateTime vizyon)
        {
            _filmAd = filmAd;
            _indirim = indirim;
            _filmTur = filmTur;
            _vizyonTarih = vizyon;
        }

        public override string ToString()
        {
            return _filmAd;
        }

        public DateTime TarihDondur() 
        {
            return _vizyonTarih;
        }

        public int IndirimOrani() 
        {
            return (_filmTur.IndirimOran() + _indirim);
        }
    }
}
