using WebaruhazTermek;

internal class Program
{
    static void Main(string[] args)
    {
        Termek termek1 = new Termek();

        termek1.Nev = "Laptop";
        termek1.Egysegar = 250000;
        termek1.Keszlet = 10;

        Termek termek2 = new Termek();

        termek2.Nev = "Egér";
        termek2.Egysegar = -500;
        termek2.Keszlet = -3;

        Console.WriteLine("1. termék:");
        Console.WriteLine("Név: " + termek1.Nev);
        Console.WriteLine("Egységár: " + termek1.Egysegar + " Ft");
        Console.WriteLine("Készlet: " + termek1.Keszlet + " db");

        Console.WriteLine();

        Console.WriteLine("2. termék:");
        Console.WriteLine("Név: " + termek2.Nev);
        Console.WriteLine("Egységár: " + termek2.Egysegar + " Ft");
        Console.WriteLine("Készlet: " + termek2.Keszlet + " db");
    }
}