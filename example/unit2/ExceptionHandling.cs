using System;
class ExceptionHandling
{
    static void Main()
    {
        Console.WriteLine("IndexOutOfRange Exception Handling");
        int[] arr1 = new int[5];
        try
        {
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = i;
                Console.WriteLine("["+i+"]="+arr1[i]);
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Array Overflow");
        }
        Console.WriteLine();

        Console.WriteLine("DivideBYZero Exception Handling");
        int[] arr2 = new int[] { 10, 20, 30, 40, 50 };
        int[] arr3 = new int[] { 2, 0, 3, 0, 2 };
        for (int i = 0; i < arr2.Length; i++)
        {
            try
            {
                Console.WriteLine("Result=" + arr2[i] / arr3[i]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error-Divide by zero");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Wrong Exception Handling & Catch all Exception");
        int[] arr4 = new int[5];
        try
        {
            for (int i = 0; i < 10; i++)
            {
                arr4[i] = i;
                Console.WriteLine("[" + i + "]=" + arr4[i]);
            }
        }
        //catch (DivideByZeroException)
        catch
        {
            Console.WriteLine("Error");
        }
        Console.WriteLine();

        Console.WriteLine("Multiple Catch Block");
        int[] arr5 = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int[] arr6 = new int[] { 2, 0, 3, 0, 2 };
        for (int i = 0; i < arr5.Length; i++)
        {
            try
            {
                Console.WriteLine("Result=" + arr5[i] / arr6[i]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error-Divide by zero");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("No elements for Division");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Nested Try Catch Block");
        int[] arr7 = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int[] arr8 = new int[] { 2, 0, 3, 0, 2 };
        try
        {
            for (int i = 0; i < arr7.Length; i++)
			{
                try 
	            {	        
		            Console.WriteLine("Result=" + arr7[i] / arr8[i]);
	            }
	            catch (DivideByZeroException)
	            {
		            Console.WriteLine("Error-Divide by zero");
	            }
			}
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("No elements for Division & Program is terminated"); 
        }
        Console.WriteLine();

        Console.WriteLine("Throw keyword example");
        try
        {
            Console.WriteLine("in try block");
            throw new IndexOutOfRangeException();
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of bound");
        }
        Console.WriteLine("Exit from try & catch");
        Console.WriteLine();

        Console.WriteLine("Finally Block");
        //int result = 0, x = 10, y = 5;
        int result = 0, x = 10, y = 0;
        try
        {
            Console.WriteLine("in try block");
            result = x / y;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error-Divide By Zero");
        }
        finally
        {
            Console.WriteLine("Reuslt=" + result);
        }
    }
}