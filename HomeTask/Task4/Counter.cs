
public class Counter
{
    public int Value { get; set; }

    public Counter(int startValue)
    {
        Value = startValue;
    }
    public Counter()
    {
        Value = 0;
    }
    public void Increase()
    {
        int plus = 0;
        plus = Value + 1;
        System.Console.WriteLine(plus);
    }
    public void Descrease()
    {
        int min = 0;
        min = Value - 1;
        System.Console.WriteLine(min);
    }
    public void IncreaseBy(int increaseBy)
    {
        if (increaseBy > 0)
        {
            Value += increaseBy;
            System.Console.WriteLine(Value);
        }
    }

    public void DecreaseBy(int decreaseBy)
    {
        if (decreaseBy > 0)
        {
            Value -= decreaseBy;
            System.Console.WriteLine(Value);
        }
    }

}