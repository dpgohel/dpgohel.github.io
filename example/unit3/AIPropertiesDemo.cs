using System;
class AIPropertiesDemo
{
    public int rollno { get; set; }
    public string name { get; set; }
}
class Program
{
    static void Main()
    {
        AIPropertiesDemo a1 = new AIPropertiesDemo();
        a1.rollno = 15;
        a1.name = "Ronak";
        Console.WriteLine("a1.rollno=" + a1.rollno);
        Console.WriteLine("a1.name=" + a1.name);
    }
}