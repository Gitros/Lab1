class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę naturalną");
        int liczbaNaturalna = int.Parse(Console.ReadLine());

        if(liczbaNaturalna % 2 == 0)
        {
            Console.WriteLine($"Liczba {liczbaNaturalna} jest parzysta.");
        } else
        {
            Console.WriteLine($"Liczba {liczbaNaturalna} jest nieparzysta.");
        }
    }
}