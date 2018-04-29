using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessizSinema
{
    class Biletler
    {
        private static Biletler nesne;
        private List<Bilet> _biletler = new List<Bilet>();

        private Biletler() { }

        public static Biletler Nesne() 
        {
            if (nesne==null)
            {
                nesne = new Biletler();
            }
            return nesne;
        }

        public void BiletlereEkle(Bilet bilet)
        {
            _biletler.Add(bilet);
        }

        public int BiletNoHesapla() {
            return _biletler.Count;
        }
    }
}
