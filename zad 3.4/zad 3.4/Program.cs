using zad_3._4;

class Program
{
    static void Main()
    {
        var magazyn = new Magazyn<Produkt>();

        magazyn.Dodaj(new Produkt("A100", "Młotek", 15));
        magazyn.Dodaj(new Produkt("B200", "Wkrętarka", 8));
        magazyn.Dodaj(new Produkt("C300", "Śrubokręt", 25));

        magazyn.WyswietlStan();
        magazyn.WyswietlSzczegoly();

        Console.WriteLine("\n> Usuwanie produktu o ID 'B200'");
        bool usunieto = magazyn.Usun("B200");
        Console.WriteLine("Usunięto: " + usunieto);

        magazyn.WyswietlStan();

        Console.WriteLine("\n> Szukanie produktu o ID 'C300'");
        var znaleziony = magazyn.ZnajdzPoId("C300");
        znaleziony?.Wyswietl();

        Console.WriteLine("\n> Sortowanie produktów po ID...");
        magazyn.PosortujPoId();
        magazyn.WyswietlSzczegoly();
    }
}
