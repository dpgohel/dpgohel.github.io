using System;
class BoxUnboxDemo
{
    static void Main()
    {
        int i = 10;
        Object o1;
        o1 = i;//boxing
        Console.WriteLine("o1 = " + o1);
        int j = (int)o1;//unboxing
        Console.WriteLine("j = " + j);
    }
}