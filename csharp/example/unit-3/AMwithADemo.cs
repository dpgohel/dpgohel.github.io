using System;
class AMwithADemo
{
    int temp;
    public AMwithADemo()
    {
        temp = 10;
    }
    public int testpro
    {
        get { return temp; }
        private set { temp = value; }
    }
    public void print()
    {
        Console.WriteLine("temp=" + temp);
    }
}
class Program
{
    static void Main()
    {
        AMwithADemo a1 = new AMwithADemo();
        a1.print();
        //a1.testpro = 20;
        Console.WriteLine("a1.testpro=" + a1.testpro);
    }
}