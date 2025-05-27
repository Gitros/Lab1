namespace zadanie3._3;

public class Osoba
{
    public string Imie { get; set; } = "Jakub";
    public string Nazwisko { get; set; } = "Owczarek";
    public int Wiek { get; set; } = 22;

    public void Wyswietl()
    {
        Console.WriteLine($"Osoba: {Imie} {Nazwisko}, Wiek: {Wiek}");
    }
}
