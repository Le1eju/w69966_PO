using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab06
{
    public enum Kolor
    {
        Czerwony,
        Niebieski,
        Zielony,
        Żółty,
        Fioletowy
    }

    internal class ZgadnijKolor
    {
        private List<Kolor> listaKolorow;
        private Kolor wylosowanyKolor;

        public ZgadnijKolor()
        {
            listaKolorow = new List<Kolor>((Kolor[])Enum.GetValues(typeof(Kolor)));

            Random random = new Random();
            wylosowanyKolor = listaKolorow[random.Next(listaKolorow.Count)];
        }

        public void RozpocznijGre()
        {
            bool odgadnieto = false;
            Console.WriteLine("Dostępne kolory: Czerwony, Niebieski, Zielony, Żółty, Fioletowy");
            

            while (!odgadnieto)
            {
                Console.WriteLine("Spróbuj zgadnąć jaki kolor wylosowano: ");
                string guess = Console.ReadLine();

                try
                {
                    if (!Enum.TryParse<Kolor>(guess, true, out Kolor wybranyKolor)) { throw new ArgumentException("Taki kolor nie istnieje na liście."); }
                    if (wybranyKolor == wylosowanyKolor)
                    {
                        Console.WriteLine("Tak! Zgadłeś B)");
                        odgadnieto = true;
                    }
                    else
                    {
                        Console.WriteLine("Nie zgadłeś, spróbuj ponownie");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
