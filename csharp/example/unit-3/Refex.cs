using System;
class Refex
{
    public void test(ref int temp)
    {
        temp = temp * 100;
        Console.WriteLine("in function=" + temp);
    }
}
class Program
{
    static void Main()
    {
        Refex o1 = new Refex();
        int temp = 10;
        Console.WriteLine("before=" + temp);
        o1.test(ref temp);
        Console.WriteLine("after=" + temp);
    }
}