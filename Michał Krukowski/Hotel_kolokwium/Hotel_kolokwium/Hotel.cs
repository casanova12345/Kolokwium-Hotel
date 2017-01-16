using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_kolokwium
{
    class Hotel : IHotel, IData
    {
        private SortedList<Pokoj, Gosc> Rezerwacje = new SortedList<Pokoj, Gosc>();
        public SortedList<Pokoj, Gosc> rezerwacje { get { return Rezerwacje; } }
        private double zysk = -80;
        private DateTime Data;

        public void DodajRezerwacje(string imie, string nazwisko, int nr, double cena)
        {
            Gosc osoba = new Gosc(imie, nazwisko);
            Pokoj innypokoj = new Pokoj(nr, cena);
            zysk += cena;
            Rezerwacje.Add(innypokoj, osoba);
          
        }
        public void  OdwolajRezerwacje()
        {
          
        }
        public void UstawDate(DateTime data)
        {
            this.Data = data;
        }
        public bool SprawdzDate()
        {
            return (Data > DateTime.Now) ? true : false;
        }
        public override string ToString()
        {
            string wyjscie = "Rezerwacje:\n\nData: " + Data.ToShortDateString();
            foreach (var a in Rezerwacje)
            {
                wyjscie += "\n\n";
                string Pokoj = a.Key.ToString() + "; " + a.Value.ToString();
                wyjscie += "[" + Pokoj + "]";
            }
            wyjscie += "\n\nZysk: " + zysk;
            return wyjscie;
        }
    }
}
