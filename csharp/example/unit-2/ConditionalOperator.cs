using System;
class ConditionalOperator
{
    static void Main()
    {
        Console.WriteLine("? Operator / Conditional Operator");
        int x = 15, y = 25, res;
        //res = x > y ? x : y;
        //Console.WriteLine("Res = " + res);
        Console.WriteLine(x > y ? "X is big" : "Y is big");

        int i = 15, j = 25, k = 50, r;
        //r = i > j ? i > k ? i : k : j > k ? j : k;
        //Console.WriteLine("R = " + r);
        Console.WriteLine(i > j ? i > k ? i : k : j > k ? j : k);
    }
}