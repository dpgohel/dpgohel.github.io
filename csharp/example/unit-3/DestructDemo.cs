using System;
class DestructDemo
{
    public int rollno;
    public string name;
    public bool isactive;
    public DefaultConst()
    {
        rollno = 11;
        name = "Raj";
        isactive = true;
    }
    ~DefaultConst()
    {
        Console.WriteLine("Object Removed");
    }
}
class Program
{
    public static void Main()
    {
        DefaultConst c1 = new DefaultConst();
        Console.WriteLine(c1.rollno);
        Console.WriteLine(c1.name);
        Console.WriteLine(c1.isactive);
    }
}