using System;
class Outex
{
    public int slice(double v, out double d)
    {
        int temp;
        temp = (int)v;
        d = v - temp;
        return temp;
    }
}
class Program
{
    static void Main()
    {
        Outex o1 = new Outex();
        int i;
        double d;
        i = o1.slice(10.36, out d);
        Console.WriteLine("i=" + i);
        Console.WriteLine("d=" + d);
    }
}