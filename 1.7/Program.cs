class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę naturalną");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj podstawę systemu");
        int s = Convert.ToInt32(Console.ReadLine());

        if(s < 2 || s > 10)
        {
            Console.WriteLine("Podstawa systemu musi być od 2 do 10");
            return;
        }

        string wynik = ConvertToBase(n, s);

        Console.WriteLine($"Liczba {n} w systemie o podstawie {s} to: {wynik}");
    }

    static string ConvertToBase( int n, int s)
    {
        if (n == 0) return "0";

        string result = string.Empty;

        while (n > 0)
        {
            result = (n % s) + result;
            n /= s;
        }

        return result;
    }
}