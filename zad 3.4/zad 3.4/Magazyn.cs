namespace zad_3._4;

public class Magazyn<T> where T : IIdentyfikacja, IZliczanie, IComparable<T> 
{
    private List<T> przedmioty = new List<T>();

    public void Dodaj(T przedmiot)
    {
        przedmioty.Add(przedmiot);
    }

    public bool Usun(string id)
    {
        var znaleziony = ZnajdzPoId(id);
        if (znaleziony != null)
        {
            przedmioty.Remove(znaleziony);
            return true;
        }
        return false;
    }

    public T ZnajdzPoId(string id)
    {
        return przedmioty.Find(p => p.Id == id);
    }

    public void WyswietlStan()
    {
        Console.WriteLine("\nStan magazynu:");
        foreach (var p in przedmioty)
        {
            Console.WriteLine($"- {p.Id} ({((IIdentyfikacja)p).GetType().Name}), Ilość: {p.Ilosc}");
        }
    }

    public void WyswietlSzczegoly()
    {
        Console.WriteLine("\nSzczegóły przedmiotów:");
        foreach (var p in przedmioty)
        {
            if (p is Produkt prod)
                prod.Wyswietl();
        }
    }

    public void PosortujPoId()
    {
        przedmioty.Sort();
    }
}
