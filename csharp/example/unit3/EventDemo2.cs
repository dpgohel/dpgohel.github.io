using System;
public delegate void operation();
class EventDemo2
{
    public event operation myevent;
    public void someoperation()
    {
        Console.WriteLine("operation performed");
        myevent();
    }
    public void handler1()
    {
        Console.WriteLine("event 1 occured");
    }
    public void handler2()
    {
        Console.WriteLine("event 2 occured");
    }
    public void handler3()
    {
        Console.WriteLine("event 3 occured");
    }
}
class Program
{
    static void Main()
    {
        EventDemo2 e1 = new EventDemo2();
        e1.myevent += e1.handler1;
        e1.myevent += e1.handler2;
        e1.myevent += e1.handler3;
        e1.someoperation();
    }
}