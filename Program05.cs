using SharpLab05;
using System.Security.Cryptography.X509Certificates;

/*
List<A> listaA = new List<A>();
List<B> listaB = new List<B>();
List<C> listaC = new List<C>();

A a1 = new A();
A a2 = new A();
B b1 = new B();
A b2 = new B();
C c1 = new C();
B c2 = new C();
A c3 = new C();

// 1a)
listaA = [a1,a2,b1,b2,c1,c2,c3];
listaB = [b1, c1, c2];
listaC = [c1];
// Obiekty klas A, B, C => ListaA
// Obiekty klas B,C => ListaB
// Obiekty klasy C => ListaC

// 1b)
foreach (A a in listaA)
{
    a.Metoda();
    a.MetodaA();
}
foreach (B b in listaB)
{
    b.Metoda();
    b.MetodaA();
}
foreach(C c in listaC)
{
    c.Metoda();
    c.MetodaA();
}
// Można wywołać obie metody w każdym przypadku
// Metoda() wywołuje nadpisania indywidualne dla każdej z klas
// MetodaA() wywołuje metodę klasy A

*/

//Debugging Punktów
/*
Punkt p1 = new Punkt(1, 5);
Punkt p2 = new Punkt();
Punkt p3 = p1.Clone();
Console.WriteLine("Distance between p1 and p2: " + p1.Distance(p2));

Console.WriteLine("Czy punkty mają takie same współrzędne?: " + p1.Equals(p2));
Console.WriteLine(p1.ToString());
Console.WriteLine(p2.ToString());

Console.WriteLine("\n\nPrzesunięcie punktu p1 o 4 w górę");
p1.Move(0, 4);
Console.WriteLine("Czy punkty mają takie same współrzędne?: " + p1.Equals(p2));
Console.WriteLine(p1.ToString());
Console.WriteLine(p2.ToString());
Console.WriteLine(p3.ToString());

Console.WriteLine("Obwód punktu p1 (powinien wynosić 0): " + p1.GetCrc());
*/

// Debugging Kół
/*
Punkt p1 = new Punkt(3,5);
Kolo k1 = new Kolo(p1,1,"Koło");
Kolo k2 = new Kolo(1,2,2,"Koło2");
Kolo k3 = new Kolo();
Kolo k4 = k1.Clone();
k4.Nazwa = "Koło4";

Console.WriteLine(k1.ToString());
Console.WriteLine(k2.ToString());
Console.WriteLine(k3.ToString());
Console.WriteLine(k4.ToString());
Console.WriteLine("Obwód k1: " + k1.GetCrc());
Console.WriteLine("Obwód k2: " + k2.GetCrc());
Console.WriteLine("Obwód k3: " + k3.GetCrc());

Console.WriteLine("= Przesunięcie =");
k2.Move(2, 3);
Console.WriteLine(k2.ToString());
Console.WriteLine("Czy k1 i k4 są identyczne: " + k1.Equals(k4));
*/
// Debugging Trójkątów
/*
Punkt pt1 = new Punkt(3,3);
Punkt pt2 = new Punkt(4,4);
Punkt pt3 = new Punkt(5,3);
List<Punkt> list = [pt1,pt2,pt3];
Trojkat t1 = new Trojkat(list, "Trójkąt1");
Trojkat t2 = new Trojkat();
Trojkat t3 = t1.Clone();
Console.WriteLine();
Console.WriteLine(t1.ToString());
Console.WriteLine(t2.ToString());
Console.WriteLine(t3.ToString());
Console.WriteLine();
Console.WriteLine("Obw t1: " + t1.GetCrc());
Console.WriteLine("Obw t2: " + t2.GetCrc());
Console.WriteLine("Obw t3: " + t3.GetCrc());
// Move t2
t2.Move(2, 2);
Console.WriteLine(t2.ToString()); // working ✅
Console.WriteLine("Is t1 equal to his clone?: "+t1.Equals(t3)); // Check if clone is equal
*/
Punkt pw1 = new Punkt(3, 3);
Punkt pw2 = new Punkt(4, 4);
Punkt pw3 = new Punkt(5, 3);
Punkt pw4 = new Punkt(12, 3);
Punkt pw5 = new Punkt(5, 8);
List<Punkt> list2 = [pw1, pw2, pw3, pw4, pw5];
List<Punkt> list3 = [pw2, pw3, pw1, pw5, pw4];
Wielobok w1 = new Wielobok(list2, "Wielobok1");
Wielobok w2 = new Wielobok(list3, "Wielobok2");
Wielobok w3 = w1.Clone();
w3.Nazwa = "Wielobok3";
Console.WriteLine();
Console.WriteLine(w1.ToString());
Console.WriteLine(w2.ToString());
Console.WriteLine(w3.ToString());
Console.WriteLine();
Console.WriteLine("Obw w1: " + w1.GetCrc());
Console.WriteLine("Obw w2: " + w2.GetCrc());
Console.WriteLine("Obw w3: " + w3.GetCrc());
Console.WriteLine();
// Move t2
w2.Move(2, 2);
Console.WriteLine("Wielobok2 po przesunięciu o wektor (2,2)");
Console.WriteLine(w2.ToString()); // working ✅
Console.WriteLine("Is w1 equal to his clone?: " + w1.Equals(w3)); // Check if clone is equal