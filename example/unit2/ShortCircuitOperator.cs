using System;
class CodeFile1
{
    static void Main()
    {
        int n, d;
        n = 10;
        d = 2;
        if(d != 0 && (n % d) == 0)
            Console.WriteLine(d + " is a factor of " + n);
	
        d = 0; // now, set d to zero
        // since d is zero, the second operand is not evaluated.
        if(d != 0 && (n % d) == 0)
            Console.WriteLine("No Error");
		
        // now, try the same thing without the short-circuit operator.
        // this will cause a divide-by-zero error.
        if(d != 0 & (n % d) == 0)
            Console.WriteLine("Compilation Error - Attempted to divide by zero");
    }
}