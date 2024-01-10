try
{
    System.Console.Write("Number = ");
    int num = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Number2 = ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int tak = num / num2;
    System.Console.WriteLine(tak);
}
catch (System.Exception)
{
    System.Console.WriteLine("Error");
}

