using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab02
{
    internal class Osoba
    {
        string imie;
        string nazwisko;
        int wiek;
        public string Imie
        {
            get => imie;
            set
            {
                if (value.Length >= 2) { imie = value; }
                else { throw new ArgumentException("Imię musi mieć conajmniej 2 znaki\n"); }
            }
        }
        public string Nazwisko
        {
            get => nazwisko;
            set
            {
                if (value.Length >= 2) { nazwisko = value; }
                else { throw new ArgumentException("Nazwisko musi mieć conajmniej 2 znaki\n"); }
            }
        }
        public int Wiek
        {
            get => wiek;
            set
            {
                if (value > 0) { wiek = value; }
                else { throw new ArgumentException("Wiek musi być liczbą dodatnią\n"); }
            }
        }
        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Imie: {Imie}\nNazwisko: {Nazwisko}\nWiek: {Wiek}");
        }
    }
}
