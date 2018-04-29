using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessizSinema
{
    class Filmler
    {
        private static Filmler nesne;
        private List<Film> _filmler = new List<Film>();

        private Filmler() { }

        public static Filmler Nesne() 
        {
            if (nesne==null)
            {
                nesne = new Filmler();
            }
            return nesne;
        }

        public void FilmlereEkle(Film film)
        {
            _filmler.Add(film);
        }

        public void FilmlerdenCikar(Film film){
             _filmler.Remove(film);
        }

        public List<Film> FilmlerListe()
        {
            return _filmler;
        }
    }
}
