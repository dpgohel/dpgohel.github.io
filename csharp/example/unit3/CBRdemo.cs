using System;
class CBRdemo
{
    public int temp;
    public CBRdemo(int t)
    {
        temp = t;
    }
    public void test(CBRdemo o)
    {
        o.temp = o.temp * 100;
        Console.WriteLine("in function=" + o.temp);
    }
}
class Program
{
    static void Main()
    {
        CBRdemo o1 = new CBRdemo(10);
        Console.WriteLine("before=" + o1.temp);
        o1.test(o1);
        Console.WriteLine("after=" + o1.temp);
    }
}