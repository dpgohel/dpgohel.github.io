using System;
class JumpStatement
{
    static void Main()
    {   //bscit
        {
            Console.WriteLine("Break");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) break;
                Console.WriteLine(i);
            }
            Console.WriteLine("End");

            Console.WriteLine("Continue");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("End");

            Console.WriteLine("goto label");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) goto end;
                Console.WriteLine(i);
            }
        end:
            Console.WriteLine("End");

            Console.WriteLine("case & default are label");
            int n = 1;
            switch (n)
            {
                case 1:
                    Console.WriteLine("in case 1");
                    goto case 2;
                case 2:
                    Console.WriteLine("in case 2");
                    goto case 3;
                case 3:
                    Console.WriteLine("in case 3");
                    goto default;
                default:
                    Console.WriteLine("in default");
                    break;
            }
        }
        //bca
        {
            Console.WriteLine("break");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5) break;

            }
            Console.WriteLine();

            Console.WriteLine("continue");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) continue;
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("goto label");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) goto exit;
                Console.WriteLine(i);
            }
            exit :
            Console.WriteLine();

            Console.WriteLine("case & default are label");
            int no = 1;
            switch (no)
            {
                case 1:
                    Console.WriteLine("in case 1");
                    goto case 2;
                case 2:
                    Console.WriteLine("in case 2");
                    goto case 3;
                case 3:
                    Console.WriteLine("in case 3");
                    goto default;
                default:
                    Console.WriteLine("in default");
                    break;
            }
            Console.WriteLine();
        }
    }
}