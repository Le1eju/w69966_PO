using System;
using System.Drawing;
using System.Runtime.InteropServices;

//Zadanie1()
//Zadanie2()
//Zadanie3()
//Zadanie4();
//Zadanie5();
//Zadanie6();
//Zadanie7();

static void Zadanie1()
{
    Console.WriteLine("=====\tTo jest program służący do obliczania Delty i pierwiastków równania kwadratowego\t=====");
    Console.WriteLine("Podaj a: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Podaj b:");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Podaj c:");
    double c = Convert.ToDouble(Console.ReadLine());
    double delta = b * b - (4 * a * c);
    double sqrtDelta;
    if ( delta > 0)
    {
        sqrtDelta = Math.Sqrt(delta);
        double x1 = (-b + sqrtDelta) / (2 * a);
        double x2 = (-b - sqrtDelta) / (2 * a);
        Console.WriteLine($"Delta = {delta}\t x1 = {x1}\tx2 = {x2}");
    }
    else if ( delta == 0)
    {
        sqrtDelta = Math.Sqrt(delta);
        double x0 = (-b) / (2 * a);
        Console.WriteLine($"Delta = {delta}\tx0 = {x0}");
    }
    else
    {
        Console.WriteLine($"Delta = {delta}\tRównanie kwadratowe nie ma rozwiązań");
    }
}

// Zadanie 2
static void Zadanie2()
{
    int next = 1;
    do
    {
        Console.Clear();
        Console.WriteLine("Wybierz działanie:\n" +
            "1. Dodawanie\n" +
            "2. Odejmowanie\n" +
            "3. Mnożenie\n" +
            "4. Dzielenie\n" +
            "5. Potęgowanie\n" +
            "6. Pierwiastkowanie\n" +
            "7. Obliczenie wartości funkcji trygonometrycznych dla podanego kąta");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        switch (input)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("===Dodawanie===");
                Console.WriteLine(liczbaA() + liczbaB());
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("===Odejmowanie===");
                Console.WriteLine(liczbaA() - liczbaB());
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("===Mnożenie===");
                Console.WriteLine(liczbaA() * liczbaB());
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("===Dzielenie===");
                Console.WriteLine(liczbaA() / liczbaB());
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("===Potęgowanie===");
                Console.WriteLine(Math.Pow(liczbaA(), liczbaB()));
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("===Pierwiastkowanie===");
                Console.WriteLine(Math.Pow(liczbaA(), (1/liczbaB())));
                break;
            case 7:
                Console.Clear();
                Console.WriteLine("===Wartości kątów===");
                double kat = podajKat();
                Console.WriteLine($"Sinus{kat}: {Math.Sin(kat)}");
                Console.WriteLine($"Cosinus{kat}: {Math.Cos(kat)}");
                Console.WriteLine($"Tanges{kat}: {Math.Tan(kat)}");
                if (Math.Tan(kat) != 0)
                {
                    Console.WriteLine($"Cotanges{kat}: {1 / Math.Tan(kat)}");
                }
                else
                {
                    Console.WriteLine("Cotanges: Nie istnieje");
                }
                break;
            default:
                Console.WriteLine("Wybrano błędną operację, spróbuj ponownie");
                break;
        }
        Console.WriteLine("Chcesz kontynuować? 1/0");
        next = Convert.ToInt32(Console.ReadLine());
    }
    while (next == 1);

    Console.Clear();
    Console.WriteLine("Koniec programu");
}
static double liczbaA()
{
    Console.WriteLine("Podaj pierwszą liczbę: ");
    double a = Convert.ToDouble(Console.ReadLine());
    return a;
}
static double liczbaB()
{
    Console.WriteLine("Podaj drugą liczbę: ");
    double b = Convert.ToDouble(Console.ReadLine());
    return b;
}
static double podajKat()
{
    Console.WriteLine("Podaj wartość kąta (w radianach):");
    double kat = Convert.ToDouble(Console.ReadLine());
    return kat;
}

// Zadanie 3
static void Zadanie3()
{
    int choice = 0;
    double[] liczby = new double[10];

    int input = 0;
    Console.WriteLine("Proszę podać 10 liczb do tabeli");

    for (int i = 0; i < liczby.Length; i++)
    {
        Console.Write($"\nPodaj liczbę nr {i + 1}: ");
        liczby[i] = Convert.ToDouble(Console.ReadLine());
    }
    do
    {
        Console.Clear() ;
        Console.WriteLine("Wybierz co chcesz zrobić:");
        Console.WriteLine("" +
            "1. Wyświetl tablicę od pierwszego do ostatniego indeksu\n" +
            "2. Wyświetl tablicę od ostatniego do pierwszego indeksu\n" +
            "3. Wyświetl elementy o nieparzystych indeksach\n" +
            "4. Wyświetl elementy o parzystych indeksach\n");
        Console.Write("Twój wybór: ");
        input = Convert.ToInt32(Console.ReadLine());

        if (input == 1)
        {
            Tabela1(liczby);
        }
        else if (input == 2)
        {
            Tabela2(liczby);
        }
        else if (input == 3)
        {
            Tabela3(liczby);
        }
        else if (input == 4)
        {
            Tabela4(liczby);
        }
        else
        {
            Console.WriteLine("Wybrałeś niepoprawną liczbę");
        }
        Console.WriteLine("Inna opcja / wyjście? (1/0) : ");
        choice = Convert.ToInt32(Console.ReadLine());
    } while (choice == 1);
}
static void Tabela1(double[] liczby)
{
    for (int i = 0; i < liczby.Length; i++)
    {
        Console.Write($"{liczby[i]}, ");
    }
    Console.WriteLine();
}
static void Tabela2(double[] liczby)
{
    for (int i = liczby.Length - 1; i >= 0; i--)
    {
        Console.Write($"{liczby[i]}, ");
    }
    Console.WriteLine();
}
static void Tabela3(double[] liczby)
{
    for (int i = 0; i < liczby.Length; i++)
    {
        if ((i % 2) == 1)
        {
            Console.Write($"{liczby[i]}, ");
        }
    }
    Console.WriteLine();
}
static void Tabela4(double[] liczby)
{
    for (int i = 0; i < liczby.Length; i++)
    {
        if ((i % 2) == 0)
        {
            Console.Write($"{liczby[i]},");
        }
    }
    Console.WriteLine();
}

// Zadanie 4

static void Zadanie4()
{
    double[] liczby4 = new double[10];

    Console.WriteLine("Proszę podać 10 liczb do tabeli");

    for (int i = 0; i < liczby4.Length; i++)
    {
        Console.Write($"\nPodaj liczbę nr {i + 1}: ");
        liczby4[i] = Convert.ToDouble(Console.ReadLine());
    }

    double suma = 0, iloczyn = liczby4[0];
    double min = liczby4[0], max = liczby4[0];
    for (int i = 0; i < liczby4.Length; i++)
    {
        suma += liczby4[i];
        iloczyn *= liczby4[i];
        min = (liczby4[i] < min) ? liczby4[i] : min;
        max = (liczby4[i] > max) ? liczby4[i] : max;
    }
    Console.WriteLine($"Suma = {suma}");
    Console.WriteLine($"Iloczyn = {iloczyn}");
    Console.WriteLine($"Średnia = {suma/liczby4.Length}");
    Console.WriteLine($"Wartość minimalna = {min}");
    Console.WriteLine($"Wartość maksymalna = {max}");
}

// Zadanie 5

static void Zadanie5()
{
    for (int i = 20; i >= 0; i--)
    {
        if (i==2 || i==6 || i==9 || i==15 || i == 19)
        {
            continue;
        }
        else
        {
            Console.Write($"{i}, ");
        }
    }
}

// Zadanie 6
static void Zadanie6()
{
    while (true)
    {
        Console.WriteLine("Podaj liczbę całkowitą");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x < 0)
        {
            break;
        }
    }
    Console.WriteLine("Tylko nie mniejsze od zera :c");
}

static void Zadanie7()
{
    Console.WriteLine("Ile liczb chcesz podać?");
    int n = Convert.ToInt32(Console.ReadLine());
    int zast = 0;

    int[] tablica = new int[n];
    Console.WriteLine("==========");
    for (int i = 0; i < tablica.Length; i++)
    {
        Console.WriteLine($"Podaj liczbę na indeks {i}: ");
        tablica[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < tablica.Length - 1; i++)
    {
        for(int j = 0; j < tablica.Length - 1 - i; j++)
        {
            if (tablica[j] > tablica[j + 1])
            {
                zast = tablica[j+1];
                tablica[j+1] = tablica[j];
                tablica[j] = zast;
            }
        }
    }
    Console.WriteLine("=====\tPosortowane Liczby\t=====");
    for (int i = 0;i < tablica.Length; i++)
    {
        Console.WriteLine(tablica[i]);
    }
}