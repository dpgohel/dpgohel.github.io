using System;
public delegate void operation();
class EventDemo1
{
    public event operation myevent;
    public void someoperation()
    {
        Console.WriteLine("operation performed");
        myevent();
    }
    public void handler1()
    {
        Console.WriteLine("event occured");
    }
}
class Program
{
    static void Main()
    {
        EventDemo1 e1 = new EventDemo1();
        e1.myevent += e1.handler1;
        e1.someoperation();
    }
}