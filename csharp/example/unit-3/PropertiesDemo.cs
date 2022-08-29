using System;
class PropertiesDemo
{
    public int temp;
    public int testpro
    {
        get
        {
            return temp;
        }
        set
        {
            temp = value;
        }
    }
}
class Program
{
    static void Main()
    {
        PropertiesDemo p1 = new PropertiesDemo();
        p1.testpro = 10;
        Console.WriteLine("p1.testpro=" + p1.testpro);
        Console.WriteLine("p1.temp=" + p1.temp);
    }
}