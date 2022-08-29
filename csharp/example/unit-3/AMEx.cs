using System;
class AMEx
{
    public int x;
    private int y;
    public void set(int temp)
    {
        y = temp;
    }
    public int get()
    {
        return y;
    }
}
class Program
{
    public static void Main()
    {
        AMEx a1 = new AMEx();
        a1.x = 10;
        a1.set(20);
        Console.WriteLine("x=" + a1.x);
        Console.WriteLine("y=" + a1.get());
    }
}