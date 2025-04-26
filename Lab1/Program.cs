// Zadanie 1.2. Napisz program, w który poprosi użytkownika o podanie nazwiska, imienia i wieku, a następnie wyświetli wczytany z klawiatury tekst.

class Program
{
    static void Main()
    {
        Console.WriteLine("Nazwisko");
        string nazwisko = Console.ReadLine();

        Console.WriteLine("Imie");
        string imie = Console.ReadLine();

        Console.WriteLine("Wiek");
        string wiekInput = Console.ReadLine();
        int wiek;

        if (int.TryParse(wiekInput, out wiek))
        {
            Console.WriteLine("\nWprowadzone dane:");
            Console.WriteLine($"Nazwisko: {nazwisko}");
            Console.WriteLine($"Imie: {imie}");
            Console.WriteLine($"Wiek: {wiek}");
        }
        else
        {
            Console.WriteLine("Podano nieprawidłowy wiek!");
        }
    }
}