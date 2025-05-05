class Program

{

    static void Main()

    {

        int[] liczby = new int[5];

        int suma = 0;



        Console.WriteLine("Podaj 5 liczb: ");



        for (int i = 0; i < liczby.Length; i++)

        {

            Console.Write($"Liczba {i + 1}: ");

            liczby[i] = int.Parse(Console.ReadLine());

            suma += liczby[i];

        }



        double srednia = (double)suma / liczby.Length;



        Console.WriteLine($"\nSuma liczb: {suma},\nŚrednia liczb: {srednia:F2}");

    }

}

