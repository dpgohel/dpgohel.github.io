using System;
class MethodOverload
{
    public void test()
    {
        Console.WriteLine("Zero Argument");
    }
    public void test(int i)
    {
        Console.WriteLine("One int Argument=" + i);
    }
    public void test(int i, int j)
    {
        Console.WriteLine("Two int Argument" + i +", "+ j);
    }
    public void test(double i)
    {
        Console.WriteLine("One double Argument=" + i);
    }
    public void test(double i, double j)
    {
        Console.WriteLine("Two double Argument" + i + ", " + j);
    }
}
class Program
{
    static void Main()
    {
        MethodOverload m1 = new MethodOverload();
        m1.test();
        m1.test(10);
        m1.test(10.10);
        m1.test(10,20);
        m1.test(10.10,20.20);
    }
}