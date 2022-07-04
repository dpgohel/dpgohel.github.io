using System;
class ParamsDemo
{
    public void test(params int[] arr)
    {
    	if (arr.Length == 0)
        {
            Console.WriteLine("No Data");
        }
        foreach (int i in arr)
        {
            Console.Write(i+",");
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main()
    {
        ParamsDemo p1 = new ParamsDemo();
        Console.WriteLine("with two arguments");
        p1.test(10,20);
        Console.WriteLine("with three arguments");
        p1.test(10,20,30);
        Console.WriteLine("with ten arguments");
        p1.test(10,20,30,40,50,60,70,80,90,100);
        Console.WriteLine("with array as argument");
        int[] arr={1,2,3,4,5};
        p1.test(arr);
        Console.WriteLine("with zero argument");
        p1.test();
    }
}