namespace zadanie3._3;

public class Ksiazka
{
    public string Tytul { get; set; } = "Wiedźmin Rozdróże kruków";
    public string Autor { get; set; } = "Andrzej Sapkowski";
    public string Wydawca { get; set; } = "Super Nowa";

    public void Wyswietl()
    {
        Console.WriteLine($"Książka: {Tytul} Autor: {Autor}, Wydawca: {Wydawca}");
    }
}
