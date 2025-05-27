class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę naturalną: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nLiczby dwucyfrowe mniejsze od {n}:");

        for (int i = 10; i < n && i < 100; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}
