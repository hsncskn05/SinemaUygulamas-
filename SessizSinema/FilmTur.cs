using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessizSinema
{
    
    public class FilmTur
    {
        private string _filmTurIsmi;
        private int _indirim;

        public void FilmTurEkle(string TurIsmi)
        {
            _filmTurIsmi = TurIsmi;
            _indirim = 0;
            
        }

        public void FilmTurEkle(string TurIsmi, int indirim) 
        {
            _filmTurIsmi = TurIsmi;
            _indirim = indirim;
        }

        public override string ToString()
        {
            return _filmTurIsmi;
        }

        public int IndirimOran() {
            return _indirim;
        }
    }
}
