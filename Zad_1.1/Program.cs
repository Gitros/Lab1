// Zadanie 1.1. Napisz program, który wczytuje długości boków prostokąta, będące liczbami naturalnymi i wypisuje jego pole i obwód

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwszą długość prostokąta.");
        var input1 = Console.ReadLine();
        int liczba1 = int.Parse(input1);

        Console.WriteLine("Podaj drugą długość prostokąta.");
        var input2 = Console.ReadLine();
        int liczba2 = int.Parse(input2);

        Console.WriteLine("Pole wynosi: " + (liczba1 * liczba2));
        Console.WriteLine("Obwód wynosi: " + (Math.Pow(liczba1, 2) + Math.Pow(liczba2, 2)));
    }
}