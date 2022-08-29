using System;
class NamedArgument
{
    public void test(int x, double y, bool z)
    {
        Console.WriteLine("x={0}, y={1}, z={2}", x, y, z);
    }
}

class Program
{
    public static void Main()
    {
        NamedArgument n1 = new NamedArgument();
        n1.test(10,15.15,true);
        //n1.test(15.15, true, 10); error
        n1.test(y:15.15, z:true, x:10);
    }
}