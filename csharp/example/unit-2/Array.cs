using System;
class Array
{
    static void Main()
    {
        Console.WriteLine("1D array with runtime initialization");
        //int[] no = new int[10];
        int[] no;
        no = new int[10];
        for (int i = 0; i < 10; i++)
        {
            no[i] = i;
            Console.WriteLine(no[i]);
        }
        Console.WriteLine();

        Console.WriteLine("1D array with compile initialization");
        //int[] ar1 = {1,2,3,4,5};
        int[] ar1 = new int[5] { 1, 2, 3, 4, 5 };
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(ar1[i]);
        }
        Console.WriteLine();

        Console.WriteLine("2D Array");
        int[,] arr2 = new int[3, 4] {
            {1,2,3,4},
            {5,6,7,8},
            {9,10,11,12}
        };
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("["+i+""+j+"]"+"="+arr2[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("3D Array");
        int[, ,] arr3 = new int[2, 3, 4]{
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
            },
            {
                {13,14,15,16},
                {17,18,19,20},
                {21,22,23,24},
            },
            
        };
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.Write(arr3[i,j,k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}