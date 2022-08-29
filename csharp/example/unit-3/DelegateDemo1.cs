using System;
public delegate double operation(double i, double j);
class DelegateDemo
{
    public double addition(double i, double j)
    {
        return i + j;
    }
    public double subtraction(double i, double j)
    {
        return i - j;
    }
    public double multiplication(double i, double j)
    {
        return i * j;
    }
    public double division(double i, double j)
    {
        return i / j;
    }
}
class Program
{
    static void Main()
    {
        DelegateDemo d1 = new DelegateDemo();
        operation op = new operation(d1.addition);
        Console.WriteLine("addition = " + op(30, 10));
        op = new operation(d1.subtraction);
        Console.WriteLine("subtraction = " + op(30, 10));
        op = new operation(d1.multiplication);
        Console.WriteLine("multiplication = " + op(30, 10));
        op = new operation(d1.division);
        Console.WriteLine("division = " + op(30, 10));
    }
}