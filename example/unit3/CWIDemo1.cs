using System;
class shape
{
    protected double height, width;
}
class triangle : shape
{
    string type;
    public triangle(string s, double h, double w)
    {
        type = s;
        height = h;
        width = w;
    }
    public void area()
    {
        Console.WriteLine("area of {0} triangle={1}",type, (1 / 2.0 * (height * width)));
    }
}
class Program
{
    static void Main()
    {
        triangle t1 = new triangle("Right", 20, 10);
        t1.area();
        triangle t2 = new triangle("Acute", 40, 20);
        t2.area();
    }
}