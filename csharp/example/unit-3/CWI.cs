using System;
class grandparent
{
    public grandparent()
    {
        Console.WriteLine("Constructor of grandparent class");
    }
}
class parent : grandparent
{
    public parent()
    {
        Console.WriteLine("Constructor of parent class");
    }
}
class child : parent
{
    public child()
    {
        Console.WriteLine("Constructor of child class");
    }
}
class Program
{
    static void Main()
    {
        child c1 = new child();
    }
}