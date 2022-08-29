using System;
class parent
{
   public int temp;
}
class child : parent
{
    //int temp; //Warning 'child.temp' hides inherited member 'parent.temp'. Use the new keyword if hiding was intended.
    new int temp;
    public void check(int i,int j)
    {
        temp = i;
        Console.WriteLine("temp=" + temp);
        base.temp = j;
        Console.WriteLine("base temp=" + base.temp);
    }
}
class Program
{
    static void Main()
    {
        child c1 = new child();
        c1.check(10,20);
    }
}