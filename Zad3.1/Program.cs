public class Meter
{
    public double Value { get; set; }
    public Meter(double value)
    {
        Value = value;
    }

    public static explicit operator Meter(Foot foot)
    {
        return new Meter(foot.Value / 3.28084);
    }

    public static implicit operator Foot(Meter meter)
    {
        return new Foot(meter.Value * 3.28084);
    }

    public override string ToString()
    {
        return $"{Value} meters";
    }
}


public class Foot
{
    public double Value { get; set; }

    public Foot(double value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return $"{Value} feet";
    }
}


class Program
{
    static void Main()
    {
        Meter meters = new Meter(1);
        Foot feet = meters;
        Console.WriteLine($"{meters} = {feet}");

        Foot feet2 = new Foot(10);
        Meter meters2 = (Meter)feet2;
        Console.WriteLine($"{feet2} = {meters2}");
    }
}