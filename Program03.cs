using SharpLab03;

// Zadanie 1
/*
List<Person> people = new List<Person>();
people.Add(new Person("Brandon", "Sanderson", 55)); // 3_1g

Person autor1 = new Person("Brandon", "Sanderson", 55);
Book ksiazka1 = new AdventureBook("Elantris", autor1, DateTime.Parse("21-04-2005"));
Book ksiazka2 = new AdventureBook("Mistborn: Final Empire", autor1, DateTime.Parse("17-07-2006"));
Book ksiazka3 = new DocumentaryBook("The Way of Kings", autor1, DateTime.Parse("31-10-2010"));
Book ksiazka4 = new DocumentaryBook("Yuumi and the Nigthmare Painter", autor1, DateTime.Parse("03-10-2023"));
Book ksiazka5 = new Book("Knights of Wind and Truth", autor1, DateTime.Parse("06-12-2024"));

// 3_1g
people.Add(new Reader("Kacper", "Chorążak", 21, [ksiazka1, ksiazka2, ksiazka3, ksiazka4, ksiazka5]));
people.Add(new Reader("Borys", "Szyc", 72, [ksiazka1, ksiazka2]));
people.Add(new Reader("Grzegorz", "Brzęszczyszczykiewicz", 32, [ksiazka2, ksiazka4]));
people.Add(new Reader("Maryla", "Rodowicz", 1052, []));

Person o = new Reader("Tomasz", "Ściebiura", 25, [ksiazka1, ksiazka2, ksiazka3, ksiazka4, ksiazka5]); // 3_1d
Console.WriteLine(o.View()); // 3_1d

// 3_1g
people.Add(new Reviewer("Kacper", "Chorążak", 21, [ksiazka1, ksiazka2, ksiazka3, ksiazka4, ksiazka5]));

foreach (Person person in people)
{
    Console.WriteLine(person.View());
}

Console.WriteLine("============");

Console.WriteLine(ksiazka1.View());
Console.WriteLine(ksiazka2.View());
Console.WriteLine(ksiazka3.View());
Console.WriteLine(ksiazka4.View());
Console.WriteLine(ksiazka5.View());
Console.WriteLine();
Console.WriteLine("============");
*/

// Zadanie 2

Samochod s1 = new Samochod("Renault", "Clio", "Hatchback", "Szare", 2003, 278000);
Samochod s2 = new Samochod("Opel", "Astra", "Sedan", "Czerwone", 2005, 164000);
Samochod s3 = new SamochodOsobowy("Toyota", "Corrola", "Hatchback", "Grafitowe", 2012, 140000, 2, 1.8, 5);
Samochod s4 = new SamochodOsobowy();

Console.WriteLine(s1.View());
Console.WriteLine(s2.View());
Console.WriteLine(s3.View());
Console.WriteLine(s4.View());