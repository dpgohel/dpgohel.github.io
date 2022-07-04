using System;
class MethodOverload
{
    public void test(int i)
    {
        Console.WriteLine("One int argument="+i);
    }
    public void test(ref int i)
    {
        Console.WriteLine("One ref int argument=" + i);
    }
    public void test(double i)
    {
        Console.WriteLine("One double argument=" + i);
    }
    //Error : Type 'MethodOverload' already defines a member called 'test' with the same parameter types

    /*public double test(double i)
    {
        Console.WriteLine("One double argument=" + i);
        return i;
    }*/
}
class Program
{
    static void Main()
    {
        MethodOverload m1 = new MethodOverload();
        int i = 10;
        double d = 30.15;
        m1.test(i);
        m1.test(ref i);
        m1.test(d);
        //double d1=m1.test(d);
        byte b = 3;
        short s = 5;
        float f = 15.15f;
        m1.test(b);//int
        m1.test(s);//int
        m1.test(f);//double
        long l = 20;
        m1.test(l);//double
    }
}