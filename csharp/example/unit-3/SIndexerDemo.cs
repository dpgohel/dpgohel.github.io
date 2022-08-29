using System;
class SIndexerDemo
{
    int[] arr1 = new int[3];
    public int this[int i]
    {
        get
        {
            return arr1[i];
        }
        set
        {
            arr1[i] = value;
        }
    }
}
class Program
{
    static void Main()
    {
        SIndexerDemo s1 = new SIndexerDemo();
        s1[0] = 10;
        s1[1] = 20;
        s1[2] = 30;
        Console.WriteLine("s1[0]=" + s1[0]);
        Console.WriteLine("s1[1]=" + s1[1]);
        Console.WriteLine("s1[2]=" + s1[2]);
    }
}