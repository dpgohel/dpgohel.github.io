using System;
class Student
{
    public int enrno;
    public string name;
    public string email;
    public void print()
    {
        Console.WriteLine("Enrno = " + enrno);
        Console.WriteLine("Name = " + name);
        Console.WriteLine("Email = " + email);
    }
}
class StudentDemo
{
    static void Main()
    {
        
        Student s1 = new Student();
        Student s2 = s1;
        s1.enrno = 2020001;
        s1.name = "Raj Kishorbhai Mehta";
        s1.email = "rajmehta@gmail.com";
        Console.WriteLine("using s1 object");
        s1.print();
        Console.WriteLine("using s2 object");
        s2.print();
    }
}