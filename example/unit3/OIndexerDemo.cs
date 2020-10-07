using System;
class OIndexerDemo
{
    int[] arr2 = new int[3];
    int[,] arr1 = new int[3,3];
    public int this[int i]
    {
        get
        {
            return arr2[i];
        }
        set
        {
            arr2[i] = value;
        }
    }
    public int this[int i, int j]
    {
        get
        {
            return arr1[i,j];
        }
        set
        {
            arr1[i,j] = value;
        }
    }
}
class Program
{
    static void Main()
    {
        OIndexerDemo s1 = new OIndexerDemo();
        s1[0, 0] = 10;
        s1[0, 1] = 20;
        s1[0, 2] = 30;
        s1[1, 0] = 40;
        s1[1, 1] = 50;
        s1[1, 2] = 60;
        s1[2, 0] = 70;
        s1[2, 1] = 80;
        s1[2, 2] = 90;
        s1[0] = 10;
        s1[1] = 20;
        s1[2] = 30;
        Console.WriteLine("s1[0, 0]=" + s1[0, 0]);
        Console.WriteLine("s1[0, 1]=" + s1[0, 1]);
        Console.WriteLine("s1[0, 2]=" + s1[0, 2]);
        Console.WriteLine("s1[1, 0]=" + s1[1, 0]);
        Console.WriteLine("s1[1, 1]=" + s1[1, 1]);
        Console.WriteLine("s1[1, 2]=" + s1[1, 2]);
        Console.WriteLine("s1[2, 0]=" + s1[2, 0]);
        Console.WriteLine("s1[2, 1]=" + s1[2, 1]);
        Console.WriteLine("s1[2, 2]=" + s1[2, 2]);
        Console.WriteLine("s1[0]=" + s1[0]);
        Console.WriteLine("s1[1]=" + s1[1]);
        Console.WriteLine("s1[2]=" + s1[2]);
    }
}