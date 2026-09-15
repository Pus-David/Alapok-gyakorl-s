using Mertekegyseg;

internal class Program
{
    static void Main(string[] args)
    {
        double meter = Atvalto.KmBolMeter(5);

        Console.WriteLine("5 km = " + meter + " méter");

        Atvalto atvalto = new Atvalto();

        atvalto.Szorzo = 100;

        double eredmeny = atvalto.EgyediAtvaltas(3);

        Console.WriteLine("3 * 100 = " + eredmeny);
    }
}