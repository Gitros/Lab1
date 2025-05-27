using System;
using zad_3._4;

public class Produkt : IIdentyfikacja, IZliczanie, IComparable<Produkt>
{
    public string Id { get; set; }
    public int Ilosc { get; set; }
    public string Nazwa { get; set; }

    public Produkt(string id, string nazwa, int ilosc)
    {
        Id = id;
        Nazwa = nazwa;
        Ilosc = ilosc;
    }

    public void Wyswietl()
    {
        Console.WriteLine($"Produkt: {Nazwa}, ID: {Id}, Ilość: {Ilosc}");
    }

    public int CompareTo(Produkt other)
    {
        if (other == null) return 1;
        return string.Compare(this.Id, other.Id, StringComparison.Ordinal);
    }
}
