using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_kolokwium
{
    class Pokoj : IComparable
    {
        private int nrPokoju;
        private double cenaZaDzien;

        public Pokoj(int nrPokoju, double cenaZaDzien)
        {
            this.nrPokoju = nrPokoju;
            this.cenaZaDzien = cenaZaDzien;
        }

        public override string ToString()
        {
            return "Pokoj, nr " + nrPokoju +"cena za dzien: " + cenaZaDzien;
        }

        public double zwrocNrPokoju()
        {
            return nrPokoju;
        }
        public double zwrocCeneZaDzien()
        {
            return cenaZaDzien;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Pokoj innyPokoj = obj as Pokoj;
            if (innyPokoj != null)
                return this.nrPokoju.CompareTo(innyPokoj.nrPokoju);
            else
                throw new ArgumentException("Objekt nie jest nr pokoju");
        }
    }
}
