using System;
class ParaConst
{
    public int rollno;
    public string name;
    public bool isactive;
    public DefaultConst(int r, string n, bool b)
    {
        rollno = r;
        name = n;
        isactive = b;
    }
}
class Program
{
    static void Main()
    {
        DefaultConst c1 = new DefaultConst(15, "Ravi", true);
        Console.WriteLine(c1.rollno);
        Console.WriteLine(c1.name);
        Console.WriteLine(c1.isactive);
    }
}