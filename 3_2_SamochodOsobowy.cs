using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab03
{
    internal class SamochodOsobowy : Samochod
    {
        double waga, pojemnoscSilnika;
        int iloscOsob;

        public double Waga
        {
            get => waga;
            set
            {
                if (value < 2)
                {
                    Console.WriteLine("Waga nie może być mniejsza niz 2t");
                    waga = 2;
                }
                else if (value > 4.5)
                {
                    Console.WriteLine("Waga nie może być większa nić 4.5t");
                    waga = 4.5;
                }
                else { waga = value; }
            }
        }
        public double PojemnoscSilnika
        {
            get => pojemnoscSilnika;
            set
            {
                if (value < 0.8)
                {
                    Console.WriteLine("Pojemność silnika nie może być mniejsza niż 0.8 l");
                    pojemnoscSilnika = 0.8;
                }
                else if (value > 3)
                {
                    Console.WriteLine("Pojemność silnika nie może być większa niż 3.0 l");
                    pojemnoscSilnika = 3;
                }
                else { pojemnoscSilnika = value; }
            }
        }
        public int IloscOsob
        {
            get => iloscOsob;
            set => iloscOsob = value;
        }

        public SamochodOsobowy()
        {
            Console.WriteLine("Podaj wagę pojazdu: ");
            Waga = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj pojemność silnika: ");
            PojemnoscSilnika = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj ilość miejsc w pojeździe: ");
            IloscOsob = Convert.ToInt32(Console.ReadLine());
        }

        public SamochodOsobowy(string marka, string model, string nadwozie, string kolor, int rokProdukcji, double przebieg, double waga, double pojemnoscSilnika, int iloscOsob)
            : base(marka, model, nadwozie, kolor, rokProdukcji, przebieg)
        {
            this.Waga = waga;
            this.PojemnoscSilnika = pojemnoscSilnika;
            this.IloscOsob = iloscOsob;
        }

        public override string View()
        {
            return base.View() + ($" - Waga:\t{Waga}\n - Pojemność Silnika:\t{PojemnoscSilnika}\n - Ilość Osób:\t{IloscOsob}");
        }
    }
}
