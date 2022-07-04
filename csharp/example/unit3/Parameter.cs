using System;
class Student
{
    public string name;
    public float printresult(int csharp, int seo, int project)
    {
        return (float) (((csharp + seo + project) * 100) / 300);
    }
}
class Result
{
    static void Main()
    {
        Student s1 = new Student();
        s1.name = "Raj Rasikbhai Mehta";
        Console.WriteLine("Result=" + s1.printresult(58, 67, 81));
    }
}