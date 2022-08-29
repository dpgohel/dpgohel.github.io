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
        s1.enrno = 2020001;
        s1.name = "Raj Kishorbhai Mehta";
        s1.email = "rajmehta@gmail.com";
        Student s2 = new Student();
        s2.enrno = 2020002;
        s2.name = "Kishan Manojbhai Hirani";
        s2.email = "kishanhirani@gmail.com";
        s1.print();
        s2.print();
    }
}