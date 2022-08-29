using System;
class Data
{
    public int x;
    public int y;
    public float result;
    public void division()
    {
        if (y == 0) return;
        result = x / y;
    }
}
class Operation
{
    static void Main()
    {
        Data d1 = new Data();
        d1.x = 10;
        d1.y = 5;
        d1.division();
        Console.WriteLine("Division = " + d1.result);
    }
}