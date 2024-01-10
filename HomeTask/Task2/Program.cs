string cip = Console.ReadLine();
int cnt = 0;
foreach (var item in cip)
{
    if (item != "end")
    {
        cnt++;
    }
}
System.Console.WriteLine(cnt);

// while (cip != "end")
// {
//     cnt++;
//     cip = Console.ReadLine();
// }
// System.Console.WriteLine(cnt);