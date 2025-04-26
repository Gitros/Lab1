class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj Nazwisko");
        string nazwisko = Console.ReadLine();

        Console.WriteLine("Podaj Imie");
        string imie = Console.ReadLine();

        Console.WriteLine("Podaj Wiek");
        string wiekInput = Console.ReadLine();
        int wiek;

        if (int.TryParse(wiekInput, out wiek))
        {
            Console.WriteLine("\nWprowadzone dane:");
            Console.WriteLine($"Nazwisko: {nazwisko}");
            Console.WriteLine($"Imię: {imie}");
            Console.WriteLine($"Wiek: {wiek}");
        }
        else
        {
            Console.WriteLine("Podano nieprawidłowy wiek!");
        }
    }
}