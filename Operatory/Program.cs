// Zadanie 3.1. Napisz program wczytujący dwie liczby całkowite i wypisujący ich sumę, różnicę, iloczyn, iloraz oraz dzielenie z resztą.class Program
{
    static void Main()
    {
        int number1 = 2;
        int number2 = 3;

        int sum = number1 + number2;
        Console.WriteLine(sum);
        int diff = number1 - number2;
        Console.WriteLine(diff);
        int product = number1 * number2;
        Console.WriteLine(product);
        int quotient = number1 / number2;
        Console.WriteLine(quotient);
        decimal sharing = number1 % number2;
        Console.WriteLine(sharing);
    }
}