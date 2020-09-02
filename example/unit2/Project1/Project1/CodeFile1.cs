using System;
class CodeFile1
{
    static void Main()
    {
        

        //int[,,] m = {
        //    {
        //        {1,2,3,4},
        //        {5,6,7,8},
        //        {9,10,11,12},
        //    },
        //    {
        //        {13,14,15,16},
        //        {17,18,19,20},
        //        {21,22,23,24},
        //    },
        //};
        
        
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        for (int k = 0; k < 4; k++)
        //        {
        //            Console.Write(m[i,j,k]);   
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //}

        int [,] arr1 = new int[3,4]{
            {1,2,3,4},
            {5,6,7,8},
            {9,10,11,12},
        };
        for (int i = 0; i < 4; i++)
        {
            Console.Write(arr1[i]+",");
        }
        Console.WriteLine();
    }
}