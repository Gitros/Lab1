namespace zadanie3._3;

public class Samochod
{
    public string Nazwa { get; set; } = "Yaris";
    public string Marka { get; set; } = "Toyota";
    public int Przebieg { get; set; } = 200;

    public void Wyswietl()
    {
        Console.WriteLine($"Samochód: {Nazwa} {Marka}, Przebieg: {Przebieg}");
    }
}
