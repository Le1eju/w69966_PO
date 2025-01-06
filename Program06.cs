using System;
using System.Reflection.Metadata;

namespace SharpLab06
{
    class SharpLab06
    {
        static void Main(string[] args)
        {
            // Zadanie 1
            Kalkulator();

            // Zadanie 2
            Zamowienia();

            // Zadanie 3
            ZgadnijKolor();
        }

        static void Kalkulator()
        {
            // Zadanie 1

            Kalkulator kalkulator = new Kalkulator();
            while (true)
            {
                try
                {
                    Console.WriteLine("Podaj pierwszą liczbę: ");
                    double liczba1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Podaj drugą liczbę: ");
                    double liczba2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Wybierz operację: \nDodawanie - 0\nOdejmowanie - 1\nMnożenie - 2\nDzielenie - 3");
                    Operacja operacja = (Operacja)Convert.ToInt32(Console.ReadLine());

                    double wynik = kalkulator.Operacje(liczba1, liczba2, operacja);
                    Console.WriteLine($"Wynik: {wynik}");

                    kalkulator.DodajWynik(wynik);
                    Console.WriteLine("Chcesz zakończyć program działanie programu? (Tak: 1 / Nie: 0)");
                    if (Convert.ToInt32(Console.ReadLine()) == 1) break;
                    Console.Clear();
                    kalkulator.PokazWyniki();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podałeś niepoprawne dane. Spróbuj ponownie.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Nie można dzielić przez zero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił błąd: {ex.Message}");
                }
            }
            Console.Clear();
        }

        static void Zamowienia()
        {
            // Zadanie 2
            Zamowienia listaZamowien = new Zamowienia();

            while (true)
            {
                try
                {
                    Console.WriteLine("Zarządzanie zamówieniami: \n" +
                        "1 - Dodaj zamówienie\n" +
                        "2-Zmień status zamówienia\n" +
                        "3- Wyświetl zamówienia\n" +
                        "4-Wyjdź\n" +
                        "Wybierz opcję: ");

                    int opcja = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    int numerZamowienia;
                    switch (opcja)
                    {
                        case 1:
                            Console.WriteLine("Podaj numer zamówienia: ");
                            numerZamowienia = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Podaj produkty (oddzielone przecinkami): ");
                            var produkty = new List<string>(Console.ReadLine().Split(','));

                            listaZamowien.DodajZamowienie(numerZamowienia, produkty);
                            Console.WriteLine("Dodano zamówienie\n");
                            break;

                        case 2:
                            Console.WriteLine("Podaj numer zamówienia: ");
                            numerZamowienia = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Wybierz nowy status:\n" +
                                "0 - Oczekujący\n" +
                                "1 - Zamówienie Przyjęte\n" +
                                "2 - Zamówienie Zrealizowane\n" +
                                "3 - Zamówienie Anulowane");

                            StatusZamowienia nowyStatus = (StatusZamowienia)Convert.ToInt32(Console.ReadLine());
                            listaZamowien.ZmienStatus(numerZamowienia, nowyStatus);

                            break;

                        case 3:
                            listaZamowien.WyswietlZamowienia();
                            break;

                        case 4:
                            return;

                        default:
                            Console.WriteLine("Wybrano nieprawidłową opcję.");
                            break;
                    }
                }
                catch (FormatException) { Console.WriteLine("Niepoprawny format danych."); }
                catch (KeyNotFoundException ex) { Console.WriteLine(ex.Message); }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
                catch (Exception ex) { Console.WriteLine($"Wystąpił błąd: {ex.Message}"); }
            }
        }
        static void ZgadnijKolor()
        {
            // Zadanie 3

            ZgadnijKolor gra = new ZgadnijKolor();
            gra.RozpocznijGre();
        }
    }
}