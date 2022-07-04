using System;
class shape
{
    protected double height, width;
}
class rectangel : shape
{
    public void set(double h, double w)
    {
        height = h;
        width = w;
    }
    public void area()
    {
        Console.WriteLine("area of rectangel=" + height * width);
    }
}
class triangle : shape
{
    public void set(double h, double w)
    {
        height = h;
        width = w;
    }
    public void area()
    {
        Console.WriteLine("area of triangle=" + (1 / 2.0 * (height * width)));
    }
}
class Program
{
    static void Main()
    {
        rectangel r1 = new rectangel();
        r1.set(10,20);
        r1.area();
        triangle t1 = new triangle();
        t1.set(20, 15);
        t1.area();
    }
}