using System;
class CodeFile1
{
    static void Main()
    {
        int num;
        num = 11;
        if ((num & 1) == 1)
            Console.WriteLine(num + " is odd.");
    }
}