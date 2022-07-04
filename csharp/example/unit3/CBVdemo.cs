using System;
class CBVdemo
{
    public void test(int temp)
    {
        temp = temp * 100;
        Console.WriteLine("in function=" + temp);
    }
}
class Program
{
    static void Main()
    {
        CBVdemo o1 = new CBVdemo();
        int temp = 10;
        Console.WriteLine("before=" + temp);
        o1.test(temp);
        Console.WriteLine("after=" + temp);
    }
}