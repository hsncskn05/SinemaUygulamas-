using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessizSinema
{
    class FilmTurler
    {
        private static FilmTurler nesne;
        private List<FilmTur> _filmTurleri=new List<FilmTur>();

        private FilmTurler() { }

        public static FilmTurler Nesne(){
            if (nesne==null)
            {
                nesne = new FilmTurler();
            }
            return nesne;

        }

        public void FilmTurlerineEkle(FilmTur ft) 
        {
            _filmTurleri.Add(ft);
        }

        public void FilmTurlerindenCikar(FilmTur ft)
        {
            _filmTurleri.Remove(ft);
        }
        public List<FilmTur> FilmTurleriListe() {
            return _filmTurleri;
        }



    }
}
