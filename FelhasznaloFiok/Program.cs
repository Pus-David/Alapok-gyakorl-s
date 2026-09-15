usning felhasznaloFiok;

static void Main(string[] args)
{
    Felhasznalo felhasznalo = new Felhasznalo();

    felhasznalo.Felhasznalonev = "TesztElek";

    Console.WriteLine($"Felhasználónév: {felhasznalo.Felhasznalonev}");

    felhasznalo.JelszoModositas("123456", "abcdef");

    felhasznalo.JelszoModositas("hibas", "qwerty");

    felhasznalo.JelszoModositas("abcdef", "123");

    felhasznalo.JelszoModositas("abcdef", "ujjelszo123");
}