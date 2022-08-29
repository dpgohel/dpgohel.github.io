using System;
interface animal
{
    void eat();
}
class lion : animal
{
    public void eat()
    {
        Console.WriteLine("Lion eating");
    }
}
class rabit : animal
{
    
}
class Program
{
    static void Main()
    {
        lion l1 = new lion();
        rabit r1 = new rabit();
        l1.eat();
        r1.eat();
    }
}