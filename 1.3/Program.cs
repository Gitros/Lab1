class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj temperature ciała");
        decimal temperaturaCiała = Convert.ToDecimal(Console.ReadLine());

        if (temperaturaCiała >= 36.6m && temperaturaCiała <= 37)
        {
            Console.WriteLine("OK");
        }
        else if (temperaturaCiała >= 37.1m && temperaturaCiała <= 38)
        {
            Console.WriteLine("stan podgorączkowy");
        }
        else if (temperaturaCiała >= 38.1m && temperaturaCiała <= 41)
        {
            Console.WriteLine("gorączka");
        }
        else
        {
            Console.WriteLine("skonsultuj się z lekarzem");
        }
    }
}