using System;
class Data
{
    public int x;
    public int y;
    public float addition()
    {
        return x + y;
    }
    public float subtraction()
    {
        return x - y;
    }
    public float multiplication()
    {
        return x * y;
    }
    public float division()
    {
        return x / y;
    }
}
class Operation
{
    static void Main()
    {
        Data d1 = new Data();
        d1.x = 10;
        d1.y = 5;
        Console.WriteLine("Addition = " + d1.addition());
        Console.WriteLine("Subtraction = " + d1.subtraction());
        Console.WriteLine("Multiplication = " + d1.multiplication());
        Console.WriteLine("Division = " + d1.division());
    }
}