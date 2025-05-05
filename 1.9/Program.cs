class Program
{
    static void Main()
    {
        int[] tablica = new int[100];

        Random rnd = new Random();

        for(int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = rnd.Next(1, 101);
        }

        Console.WriteLine("tablica");
        foreach(int liczba in tablica)
        {
            Console.WriteLine(liczba + " ");
        }
        Console.WriteLine();

        int najmniejsza = tablica[0];
        int najwieksza = tablica[0];

        foreach(int liczba in tablica)
        {
            if (liczba < najmniejsza)
                najmniejsza = liczba;
            if (liczba > najwieksza)
                najwieksza = liczba;
        }

        Console.WriteLine($"Najmniejsza wartość to {najmniejsza}");
        Console.WriteLine($"Najwieksza wartość to {najwieksza}");
    }
}