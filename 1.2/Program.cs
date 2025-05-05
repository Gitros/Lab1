class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj cenę netto");
        decimal cenaNetto = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Podaj stawkę VAT %");
        decimal stawkaVAT = Convert.ToDecimal(Console.ReadLine());

        decimal kwotaVAT = cenaNetto * (stawkaVAT / 100);

        decimal cenaBrutto = cenaNetto + kwotaVAT;

        Console.WriteLine($"Kwota VAT: {kwotaVAT:C2}");
        Console.WriteLine($"Cena brutto: {cenaBrutto:C2}");
    }
}