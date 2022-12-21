using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cseveges
{
    internal class Beszelgetes
    {
        public DateTime Kezdet;
        public DateTime Veg;
        public string Kezdemenyezo;
        public string Fogado;
        public TimeSpan osszIdo => Veg - Kezdet;

        public Beszelgetes(string sor)
        {
            var dbok = sor.Split(';');
            Kezdet = DateTime.ParseExact(dbok[0], "yy.MM.dd-HH:mm:ss", CultureInfo.InvariantCulture);
            Veg = DateTime.ParseExact(dbok[1], "yy.MM.dd-HH:mm:ss", CultureInfo.InvariantCulture);
            Kezdemenyezo = dbok[2];
            Fogado = dbok[3];
        }
    }
}
