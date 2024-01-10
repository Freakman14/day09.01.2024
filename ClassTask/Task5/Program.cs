using System.Drawing;

var cip = new Programm();
cip.Color = (RGB)Convert.ToInt32(Console.ReadLine());
switch (cip.Color)
{
    case RGB.red:
        System.Console.WriteLine("RGB(09,235,3)");
        break;
    case RGB.green:
        System.Console.WriteLine("RGB(09,544,12)");
        break;
    case RGB.blue:
        System.Console.WriteLine("RGB(89,56,786)");
        break;
    case RGB.black:
        System.Console.WriteLine("RGB(23,456,07)");
        break;
}

public class Programm
{
    public RGB Color { get; set; }
}

public enum RGB 
{
    red = 1,
    green,
    blue,
    black
}
