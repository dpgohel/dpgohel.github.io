using System;
class RefObjex
{
    int a, b;
    public RefObjex(int x, int y)
    {
        a = x;
        b = y;
    }
    public void print()
    {
        Console.WriteLine("a={0}, b={1}", a, b);
    }
    public void swap(ref RefObjex o1, ref RefObjex o2)
    {
        RefObjex temp;
        temp = o1;
        o1 = o2;
        o2 = temp;
    }
}
class Program
{
    static void Main()
    {
        RefObjex r1 = new RefObjex(10, 20);
        RefObjex r2 = new RefObjex(30, 40);
        Console.WriteLine("r1");
        r1.print();
        Console.WriteLine("r2");
        r2.print();
        r1.swap(ref r1, ref r2);
        Console.WriteLine("r1");
        r1.print();
        Console.WriteLine("r2");
        r2.print();
    }
}