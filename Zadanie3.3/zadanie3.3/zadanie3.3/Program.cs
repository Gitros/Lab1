using zadanie3._3;

class Program
{
    static void Main()
    {
        var generatorSamochod = new GeneratorObiektow<Samochod>();
        Samochod auto = generatorSamochod.Create();
        auto.Wyswietl();

        var generatorKsiazka = new GeneratorObiektow<Ksiazka>();
        Ksiazka ksiazka = generatorKsiazka.Create();
        ksiazka.Wyswietl();

        var generatorOsoba = new GeneratorObiektow<Osoba>();
        Osoba osoba = generatorOsoba.Create();
        osoba.Wyswietl();
    }
}