using System;
class parent
{
    public virtual void temp()
    {
        Console.WriteLine("virtual method of parent class");
    }
}
class child1 : parent
{
    public override void temp()
    {
        Console.WriteLine("virtual method of child1 class");
    }
}
class child2 : parent
{
    public override void temp()
    {
        Console.WriteLine("virtual method of child2 class");
    }
}
class Program
{
    static void Main()
    {
        parent p1 = new parent();
        child1 c1 = new child1();
        child2 c2 = new child2();
        parent p;

        p = p1;
        p.temp();

        p = c1;
        p.temp();

        p = c2;
        p.temp();
    }
}