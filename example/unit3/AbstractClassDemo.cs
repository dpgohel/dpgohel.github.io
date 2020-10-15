using System;
abstract class shape
{
    protected double height;
    protected double width;
    protected string name;
    public shape()
    {
        height = width = 0;
        name = null;
    }
    public abstract void area();
}
class rectangle : shape
{
    public rectangle(double h, double w, string n)
    {
        height = h;
        width = w;
        name = n;
    }
    public override void area()
    {
        Console.WriteLine("Area of {0} = {1}", name, (height * width));
    }
}
abstract class triangle : shape
{
    public triangle(double h, double w, string n)
    {
        height = h;
        width = w;
        name = n;
    }
    //public override void area()
    //{
    //    Console.WriteLine("Area of {0} = {1}", name, ((height * width) / 2.0));
    //}
}
class Program
{
    static void Main()
    {
        //shape s1 = new shape(); Error	Cannot create an instance of the abstract class or interface 'shape'
        rectangle r1 = new rectangle(10, 20, "rectangle");
        //triangle t1 = new triangle(20, 10, "triangle");
        r1.area();
        //t1.area();
    }
}