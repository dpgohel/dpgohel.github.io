using System;
class Rect
{
    int height;
    int width;
    public Rect(int h, int w)
    {
        height = h;
        width = w;
    }
    public bool check(Rect r)
    {
        if ((height == r.height) & (width == r.width))
            return true;
        else
            return false;
    }
    public void copy(Rect r)
    {
        height = r.height;
        width = r.width;
    }
    public void print()
    {
        Console.WriteLine("height=" + height);
        Console.WriteLine("width=" + width);
        Console.WriteLine("Area=" + (height * width));
    }
}
class Program
{
    static void Main()
    {
        Rect r1 = new Rect(10, 20);
        r1.print();
        Rect r2 = new Rect(20, 40);
        r2.print();
        if (r1.check(r2))
            Console.WriteLine("both are same");
        else
            Console.WriteLine("both are different");
        r1.copy(r2);
        if (r1.check(r2))
            Console.WriteLine("both are same");
        else
            Console.WriteLine("both are different");
    }
}