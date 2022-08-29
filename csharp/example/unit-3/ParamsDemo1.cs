using System;
class ParamsDemo
{
    public int test(params int[] arr)
    {
        int m;
        if (arr.Length == 0)
        {
            Console.Write("No Data");
            return 0;
        }
        if (arr.Length == 1)
        {
            m = arr[0];
            return m; 
        }
        m = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < m)
                m = arr[i];
        }
        return m;
    }
}
class Program
{
    static void Main()
    {
        int m = 0;
        ParamsDemo p1 = new ParamsDemo();
        m=p1.test(56,85,17);
        Console.WriteLine("Minimum Value=" + m);
        m = p1.test(56, 85, 17, 100, 5, 99);
        Console.WriteLine("Minimum Value=" + m);
        m = p1.test(56);
        Console.WriteLine("Minimum Value=" + m);
        m = p1.test();
        Console.WriteLine("Minimum Value=" + m);
    }
}