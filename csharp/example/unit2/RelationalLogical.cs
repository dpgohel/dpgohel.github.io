using System;
class CodeFile1
{
    static void Main()
    {
        Console.WriteLine("Relational (==,!=,<,>,<=,>=)");
        int v1 = 10, v2 = 5;
        Console.WriteLine(v1 != v2);
        if (v1 == v2) Console.WriteLine(v1 + "==" + v2);
        if (v1 != v2) Console.WriteLine(v1 + "!=" + v2);
        if (v1 < v2) Console.WriteLine(v1 + "<" + v2);
        if (v1 > v2) Console.WriteLine(v1 + ">" + v2);
        if (v1 <= v2) Console.WriteLine(v1 + "<=" + v2);
        if (v1 >= v2) Console.WriteLine(v1 + ">=" + v2);
        Console.WriteLine();

        Console.WriteLine("Logiacal (&,|,!,^,&&,||)");
        bool b1 = true, b2 = false;
        if (b1 & b2) Console.WriteLine(b1 + "&" + b2);
        if (b1 | b2) Console.WriteLine(b1 + "|" + b2);
        if (!(b1 & b2)) Console.WriteLine("!"+b1 + "&" + b2);
        if (b1 ^ b2) Console.WriteLine(b1 + "^" + b2);
        Console.WriteLine();

        Console.WriteLine("Short Circuit (&&,||)");
        int n = 10, d = 0;
        if (d != 0 && (n % d) == 0) Console.WriteLine(d + " is factor of " + n);
        //Runtime Error:Attempted to divide by zero.
        //if (d != 0 & (n % d) == 0) Console.WriteLine(d + " is factor of " + n);

    }
}