class Program
{
    static void Main()
    {
        string[] imiona = new string[10];

        for(int i = 0; i < imiona.Length; i++)
        {
            Console.WriteLine($"Podaj imię #{i+1}");
            imiona[i] = Console.ReadLine();
        }

        Console.WriteLine("Odwrócone imiona: ");
        for(int i = imiona.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(imiona[i]);
        }
    }
}