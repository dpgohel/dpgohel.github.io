using System;
class Program
{
    public static int Main(string[] args)
    {
        foreach (var item in args)
        {
            Console.WriteLine(item);
        }
        return 1;
    }
}