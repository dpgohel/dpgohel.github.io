using System;
class grandparent
{
    public virtual void temp()
    {
        Console.WriteLine("virtual method of grandparent class");
    }
}
class parent : grandparent 
{
    public override void temp()
    {
        Console.WriteLine("virtual method of parent class");
    }
}
class child : parent
{
    
}
class Program
{
    static void Main()
    {
        grandparent g1 = new grandparent();
        parent p1 = new parent();
        child c1 = new child();
        
        grandparent g;

        g = g1;
        g.temp();

        g = p1;
        g.temp();

        g = c1;
        g.temp();
    }
}