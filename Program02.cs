using SharpLab02;
using System;


// Zadanie 1

/*
try
{
    Osoba osoba = new Osoba("Kacper", "Chorążak", 21);
    osoba.WyswietlInformacje();
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
*/

// Zadanie 2

/*
BankAccount konto1 = new BankAccount("Kacper Chorążak", 2000);
konto1.Wplata(500);
Console.WriteLine(konto1.Saldo);
konto1.Wyplata(2500);
Console.WriteLine(konto1.Saldo);
*/

// Zadanie 3

/*
Student student1 = new Student("Kacper", "Chorążak");
student1.DodajOcene(3);
student1.DodajOcene(4.5);
student1.DodajOcene(3);
student1.DodajOcene(7);
Console.WriteLine($"Srednia ocen wynosi: {student1.SredniaOcen()}");
*/

// Zadanie 4

/*
Licz test1 = new Licz(12);
Licz test2 = new Licz(3);
test1.Dodaj(12);
Console.WriteLine("Wartość wynosi " + test1.Wypisz());
Console.WriteLine("Wartość wynosi " + test2.Wypisz());
test1.Odejmij(test2.Wypisz());
Console.WriteLine("Wartość wynosi " + test1.Wypisz());
Console.WriteLine("Wartość wynosi " + test2.Wypisz());
test2.Odejmij(11);
Console.WriteLine("Wartość wynosi " + test1.Wypisz());
Console.WriteLine("Wartość wynosi " + test2.Wypisz());
*/

// Zadanie 5

Sumator lista1 = new Sumator([4,1,3,56,1,7]);
Console.WriteLine(lista1.IleElementow());
lista1.WypiszElementy();
lista1.Parametrownia(0, 5);
lista1.Parametrownia(3, 7);
lista1.Parametrownia(-1, 4);
lista1.Parametrownia(3, 15);
lista1.Parametrownia(4, 1);