using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab06
{
    public enum StatusZamowienia
    {
        Oczekujace,
        Przyjete,
        Zrealizowane,
        Anulowane
    }

    internal class Zamowienia
    {
        private Dictionary<int, (List<string> produkty, StatusZamowienia status)> dziennikZamowien;
        public Zamowienia()
        {
            dziennikZamowien = new Dictionary<int, (List<string>, StatusZamowienia)>();
        }

        public void DodajZamowienie(int numerZamowienia, List<string> produkty)
        {
            if (dziennikZamowien.ContainsKey(numerZamowienia))
            {
                throw new ArgumentException("Zamówienie o takim numerze już isnieje");
            }
            dziennikZamowien[numerZamowienia] = (produkty, StatusZamowienia.Oczekujace);
        }

        public void ZmienStatus(int numerZamowienia, StatusZamowienia nowyStatus)
        {
            if (!dziennikZamowien.ContainsKey(numerZamowienia))
            {
                throw new KeyNotFoundException("Zamówienie o takim numerze nie istnieje");
            }
            var (produkty, obecnyStatus) = dziennikZamowien[numerZamowienia];
        
            if (obecnyStatus == nowyStatus)
            {
                throw new ArgumentException("Status zamówienia jest już zaktualizowany");
            }
            dziennikZamowien[numerZamowienia] = (produkty, nowyStatus);
            Console.WriteLine($"Status zamówienia {numerZamowienia} został zmieniony na {nowyStatus}\n");
        }

        public void WyswietlZamowienia()
        {
            Console.WriteLine("Lista zamówień: ");
            foreach (var zamowienie in dziennikZamowien)
            {
                Console.WriteLine($"Numer: {zamowienie.Key}, Status: {zamowienie.Value.status}, Produkty: {string.Join(",", zamowienie.Value.produkty)}\n");
            }
        }


    }
}
