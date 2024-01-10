var prog = new Programm();
prog.month = (Month)Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(prog.month);
public class Programm
{
    public Month month { get; set; }
}


public enum Month
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    Jule,
    August,
    September,
    October,
    November,
    December
}