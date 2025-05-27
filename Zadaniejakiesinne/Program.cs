using System;

class Program
{
    static void Main()
    {
        int[] liczby = new int[5];
        int suma = 0;

        Console.WriteLine("Podaj 5 liczb całkowitych:");

        for (int i = 0; i < liczby.Length; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            liczby[i] = int.Parse(Console.ReadLine());
            suma += liczby[i];
        }

        double srednia = (double)suma / liczby.Length;

        Console.WriteLine($"\nSuma: {suma}");
        Console.WriteLine($"Średnia: {srednia}");
    }
}
