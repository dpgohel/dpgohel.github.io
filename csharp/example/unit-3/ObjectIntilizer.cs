using System;
class ObjectInitilizer
{
    public int x;
    public double y;
    public string z;
    
}
class Program
{
    static void Main()
    {
        ObjectInitilizer o1 = new ObjectInitilizer { x = 10, y = 15.15, z="Hello Students" };
        Console.WriteLine(o1.x);
        Console.WriteLine(o1.y);
        Console.WriteLine(o1.z);
    }
}