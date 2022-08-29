using System;
class OIWAIPropertiesDemo
{
    public int rollno { get; set; }
    public string name { get; set; }
}
class Program
{
    static void Main()
    {
        OIWAIPropertiesDemo a1 = new OIWAIPropertiesDemo { rollno=25, name="Janak" };
        Console.WriteLine("a1.rollno=" + a1.rollno);
        Console.WriteLine("a1.name=" + a1.name);
    }
}