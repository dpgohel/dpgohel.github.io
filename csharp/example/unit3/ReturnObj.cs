using System;
class ReturnObj
{
    int height, width;
    public ReturnObj(int h, int w)
    {
        height = h;
        width = w;
    }
    public void print()
    {
        Console.WriteLine("height={0}, width={1}",height,width);
    }
    public void area()
    {
        Console.WriteLine("Area="+(height*width));
    }
    public ReturnObj test()
    {
        return new ReturnObj(30, 40);
    }
}
class Program
{
    static void Main()
    {
        ReturnObj r1 = new ReturnObj(10, 20);
        Console.WriteLine("r1");
        r1.print();
        r1.area();
        ReturnObj r2 = r1.test();
        Console.WriteLine("r2");
        r2.print();
        r2.area();
    }
}