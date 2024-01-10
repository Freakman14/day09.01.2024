public class Gauge
{
    public int Value { get; set; }
    public Gauge()
    {
        Value = 0;
    }

    public void Enhance()
    {
        int all = 0;
        if (Value < 5)
        {
            all = Value + 1;
        }
        System.Console.WriteLine(all);

    }
    public void Decrease()
    {
        int min = 0;
        if (Value > 0)
        {
            min = Value - 1;
        }
        System.Console.WriteLine(min);
    }
    public bool Full()
    {
        if (Value == 5)
        {
            return true;
        }
        else return false;
    }
}
