using System;
class ObjectUniversalDemo
{
    static void Main()
    {
        Object[] o1 = new Object[5]{10, 10.25, "Hello Students", true, 'A'};
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("o1[i] = " + o1[i]);
        }
        //foreach (var i in o1)
        //{
        //    Console.WriteLine("o1=" + i);
        //}
    }
}