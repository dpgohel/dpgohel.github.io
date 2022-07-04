using System;
class Rect
{
    public int height;
    public int width;
    public Rect(int height, int width)
    {
        this.height = height;
        this.width = width;
    }
    public int Area()
    {
        return height * width;
    }
}
class Program
{
    public static void Main()
    {
        Rect r1 = new Rect(10, 20);
        Console.WriteLine("Result of area=" + r1.Area());
    }
}