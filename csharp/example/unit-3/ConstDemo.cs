using System;
class ConstDemo
{
    public int rollno;
    public string name;
    public bool isactive;
}
class Program
{
    static void Main()
    {
        ConstDemo c1 = new ConstDemo();
        Console.WriteLine(c1.rollno);
        Console.WriteLine(c1.name);
        Console.WriteLine(c1.isactive);
    }
}