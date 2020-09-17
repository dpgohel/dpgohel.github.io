using System;
class SelectionStatement
{
    static void Main()
    {
        Console.WriteLine("if statement");
        int i=0;
        if (i < 0) Console.WriteLine("Negative Number");
        if (i > 0) Console.WriteLine("Positive Number");
        Console.WriteLine();

        Console.WriteLine("if else statement");
        if (i < 0) Console.WriteLine("Negative Number");
        else Console.WriteLine("Positive Number");
        Console.WriteLine();

        Console.WriteLine("else if ladder statement");
        if (i == 0) 
            Console.WriteLine("number is Zero");
        else if (i < 0) 
            Console.WriteLine("Negative Number");
        else 
            Console.WriteLine("Positive Number");
        Console.WriteLine();

        Console.WriteLine("nested if else");
        int x = 10, y = 25, z = 35;
        if (x > y)
        {
            if(x > z)
                Console.WriteLine(x);
            else
                Console.WriteLine(y);
        }
        else
        {
            if(y > z)
                Console.WriteLine(y);
            else
                Console.WriteLine(z);
        }

        Console.WriteLine("switch");
        int no = 4;
        switch (no)
        {
            case 1:
                Console.WriteLine("in case 1");
                break;
            case 2:
                Console.WriteLine("in case 2");
                break;
            case 3:
                Console.WriteLine("in case 3");
                break;
            default:
                Console.WriteLine("default");
                break;
        }
        bool b = false;
        switch (b)
        {
            case true:
                Console.WriteLine("true");
                break;
            case false:
                Console.WriteLine("false");
                break;
        }
        char ch = 'i';
        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Owels");
                break;
            default:
                Console.WriteLine("Not owels");
                break;
        }
    }
}