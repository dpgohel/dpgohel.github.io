using System;
class ConstOverload
{
    public ConstOverload()
    {
        Console.WriteLine("zero argumenet");
    }
    public ConstOverload(int i)
    {
        Console.WriteLine("one int argumenet i={0}", i);
    }
    public ConstOverload(double d)
    {
        Console.WriteLine("one double argumenet d={0}", d);
    }
    public ConstOverload(int i,int j)
    {
        Console.WriteLine("two int argumenet i={0}, j={1}",i,j);
    }
}
class Program
{
    static void Main()
    {
        ConstOverload c1 = new ConstOverload();
        ConstOverload c2 = new ConstOverload(10);
        ConstOverload c3 = new ConstOverload(15.15);
        ConstOverload c4 = new ConstOverload(12,16);
    }
}