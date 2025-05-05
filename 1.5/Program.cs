class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę od 1 do 7");
        int dzien = int.Parse(Console.ReadLine());

        switch(dzien)
        {
            case 1:
                Console.WriteLine("Poniedziałek");
                break;
            case 2:
                Console.WriteLine("Wtorek");
                break;
            case 3:
                Console.WriteLine("Środa");
                break;
            case 4:
                Console.WriteLine("Czwartek");
                break;
            case 5:
                Console.WriteLine("Piątek");
                break;
            case 6:
                Console.WriteLine("Sobota");
                break;
            case 7:
                Console.WriteLine("Niedziela");
                break;
        }
    }
}