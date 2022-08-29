using System;

class LoopingStatement
{
    static void Main()
    {
        //bscit
        {
            Console.WriteLine("for loop example");
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            Console.WriteLine("Using Multiple Loop Control Variables");
            int x, y;
            for (x = 0, y = 10; x < y; x++, y--)
            {
                Console.WriteLine(x + "-" + y);
            }
            Console.WriteLine();

            Console.WriteLine("The Conditional Expression");
            bool b = true;
            int z;
            for (z = 0; b; z++)
            {
                Console.Write(z + ",");
                if (z == 5) b = false;
            }
            Console.WriteLine();

            Console.WriteLine("Missing Pieces");
            int m = 0;
            for (; m < 5; )
            {
                Console.Write(m + ",");
                m++;
            }
            Console.WriteLine();

            //Console.WriteLine("The Infinite Loop");
            //for ( ; ; )
            //{
            //    Console.WriteLine("Hello");
            //}
            //Console.WriteLine();

            Console.WriteLine("Loops with No Body");
            int n, r = 0;
            for (n = 1; n <= 5; r += n++) ;
            Console.Write("R=" + r);
            Console.WriteLine();

            Console.WriteLine("Declaring Loop Control Variables Inside the for Loop");
            for (int p = 0; p < 5; p++)
                Console.Write(p + ",");
            Console.WriteLine();

            Console.WriteLine("while");
            int c = 0;
            while (c < 5)
            {
                Console.Write(c + ",");
                c++;
            }
            Console.WriteLine();

            Console.WriteLine("do while");
            int d = 0;
            do
            {
                Console.Write(d + ",");
                d++;
            } while (d < 5);
            Console.WriteLine();
        }
        //bca
        {
            Console.WriteLine("for");
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            Console.WriteLine("Declaring Loop Control Variables Inside the for Loop");
            for (int j = 0; j < 5; j++)
            {
                Console.Write(j + ",");
            }
            Console.WriteLine();

            Console.WriteLine("Using Multiple Loop Control Variables");
            for (int x = 0, y = 10; x < y; x++, y--)
            {
                Console.WriteLine(x+"-"+y);
            }
            Console.WriteLine();

            Console.WriteLine("The Conditional Expression");
            bool b = true;
            for (int z = 0; b; z++)
            {
                Console.WriteLine(z);
                if (z == 5) b = false;
            }
            Console.WriteLine();

            Console.WriteLine("Missing Pieces");
            int l = 0;
            for (; l < 5;)
            {
                Console.WriteLine(l);
                l++;
            }
            Console.WriteLine();

            //Console.WriteLine("The Infinite Loop");
            //for (; ; )
            //{
            //    Console.WriteLine("infinite loop");
            //}
            //Console.WriteLine();

            Console.WriteLine("Loops with No Body");
            int sum = 0;
            for (int k = 1; k <= 5; sum+=k++) ;
            Console.WriteLine("sum=" + sum);
            Console.WriteLine();

            Console.WriteLine("while");
            int w = 0;
            while (w < 5)
            {
                Console.WriteLine(w);
                w++;
            }
            Console.WriteLine();
            w=0;
            Console.WriteLine("do-while");
            do
            {
                Console.WriteLine(w);
                w++;
            } while (w < 5);
            Console.WriteLine();
        }
    }
}