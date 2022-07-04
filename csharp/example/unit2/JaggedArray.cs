using System;
class JaggedArray
{
    static void Main()
    {
        Console.WriteLine("jagged array");
        int[][] arr1 = new int[2][];
        arr1[0] = new int[3] { 1, 2, 3 };
        arr1[1] = new int[5] { 4, 5, 6, 7, 8 };
        for (int i = 0; i < arr1[0].Length; i++)
            Console.Write(arr1[0][i]+",");
        Console.WriteLine();
        for (int i = 0; i < arr1[1].Length; i++)
            Console.Write(arr1[1][i] + ",");
        Console.WriteLine();
        
        Console.WriteLine("multidimensional jagged array");
        int[][,] arr2 = new int[2][,];
        arr2[0] = new int[3, 4]{
            {1,2,3,4},
            {5,6,7,8},
            {9,10,11,12},
        };
        arr2[1] = new int[2, 3]{
            {13,14,15},
            {16,17,18},
        };
        Console.WriteLine("arr2[0]");
        for (int i = 0; i < arr2[0].GetLength(0); i++)
        {
            for (int j = 0; j < arr2[0].GetLength(1); j++)
            {
                Console.Write(arr2[0][i,j]+",");
            }
            Console.WriteLine();
        }
        Console.WriteLine("arr2[1]");
        for (int i = 0; i < arr2[1].GetLength(0); i++)
        {
            for (int j = 0; j < arr2[1].GetLength(1); j++)
            {
                Console.Write(arr2[1][i, j] + ",");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Rank - to find total dimension");
        int[,,] arr3 = new int[2, 3, 4];
        Console.WriteLine(arr3.Rank);
        Console.WriteLine("Length - to find total no. of elements");
        Console.WriteLine(arr3.Length);
        Console.WriteLine("GetLength - to find total no. of elements in specific dimension");
        Console.WriteLine(arr3.GetLength(2));
        Console.WriteLine("example-1");
        int[] arr4 = new int[5]{1,2,3,4,5};
        for (int i = 0; i < arr4.Length; i++)
        {
            Console.Write(arr4[i]+",");
        }
        Console.WriteLine();
        Console.WriteLine("example-2");
        int[,] arr5 = new int[2, 3]{
            {1,2,3},
            {4,5,6},
        };
        for (int i = 0; i < arr5.GetLength(0); i++)
        {
            for (int j = 0; j < arr5.GetLength(1); j++)
            {
                Console.Write(arr5[i, j] + ",");
            }
            Console.WriteLine();
        }
    }
}