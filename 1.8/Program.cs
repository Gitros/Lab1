class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę naturalną");
        int liczba = int.Parse(Console.ReadLine());

        int sumaCyfr = SumaCyfr(liczba);

        Console.WriteLine($"Suma cyfr liczby {liczba} wynosi {sumaCyfr}");
    }

    static int SumaCyfr(int liczba)
    {
        liczba = Math.Abs(liczba);

        int suma = 0;

        while (liczba > 0)
        {
            suma += liczba % 10;
            liczba /= 10;
        }

        return suma;
    }
}