using System;
public delegate void operation(double i, double j);
class DelegateDemo
{
    public void addition(double i, double j)
    {
        Console.WriteLine("addition = " + (i + j));
    }
    public void subtraction(double i, double j)
    {
        Console.WriteLine("subtraction = " + (i - j));
    }
    public void multiplication(double i, double j)
    {
        Console.WriteLine("multiplication = " + (i * j));
    }
    public void division(double i, double j)
    {
        Console.WriteLine("division = " + (i / j));
    }
}
class Program
{
    static void Main()
    {
        DelegateDemo d1 = new DelegateDemo();
        operation op = new operation(d1.addition);
        op += d1.subtraction;
        op += d1.multiplication;
        op += d1.division;
        op(30, 10);
        Console.WriteLine("after remove from list");
        op -= d1.multiplication;
        op(30, 10);
    }
}