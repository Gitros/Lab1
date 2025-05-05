class Program
{
    static void Main()
    {
        int liczba;
        int suma = 0;

        do
        {
            Console.WriteLine("Podaj liczby do sumowania, zakończ podając liczbę 0");
            liczba = Convert.ToInt32(Console.ReadLine());

            suma += liczba;
        } while (liczba != 0);

        Console.WriteLine(suma);
    }
}