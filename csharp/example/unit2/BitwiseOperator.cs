using System;
class BitwiseOperator
{
    static void Main()
    {   
        //bscit
        {
            Console.WriteLine("odd-even");
            // 0110 = 6
            // 0001 = 1
            //&0000 = 0
            int oe = 6;
            if ((oe & 1) != 0)
                Console.WriteLine(oe + " is ODD");
            if ((oe & 1) == 0)
                Console.WriteLine(oe + " is EVEN");
            Console.WriteLine("\n");

            Console.WriteLine("show binary number");
            // 00001110 = 14
            // 00000001 = 1
            // 00000000 = 0
            sbyte bv = 14;
            for (int i = 128; i > 0; i /= 2)
            {
                if ((bv & i) != 0) Console.Write("1");
                if ((bv & i) == 0) Console.Write("0");
            }
            Console.WriteLine("\n");

            Console.WriteLine("bitwise not");
            // 00001010 = 10
            sbyte n = 10;
            n = (sbyte)~n;
            for (int i = 128; i > 0; i /= 2)
            {
                if ((n & i) != 0) Console.Write("1");
                if ((n & i) == 0) Console.Write("0");
            }
            Console.WriteLine("\n");

            Console.WriteLine("bitwise and");
            // 00001010 = 10
            // 00000101 = 5
            //&00000000 = 0
            sbyte val1 = 10, val2 = 5, res1;
            res1 = (sbyte)(val1 & val2);
            for (int i = 128; i > 0; i /= 2)
            {
                if ((res1 & i) != 0) Console.Write("1");
                if ((res1 & i) == 0) Console.Write("0");
            }
            Console.WriteLine("\n");

            Console.WriteLine("bitwise OR");
            // 00001010 = 10
            // 00000101 = 5
            //|00001111 = 15
            sbyte val3 = 10, val4 = 5, res2;
            res2 = (sbyte)(val3 | val4);
            for (int i = 128; i > 0; i /= 2)
            {
                if ((res2 & i) != 0) Console.Write("1");
                if ((res2 & i) == 0) Console.Write("0");
            }
            Console.WriteLine("\n");

            Console.WriteLine("bitwise XOR");
            // 00001010 = 10
            // 00000101 = 5
            //|00001111 = 15
            sbyte val5 = 10, val6 = 5, res3;
            res3 = (sbyte)(val5 | val6);
            for (int i = 128; i > 0; i /= 2)
            {
                if ((res3 & i) != 0) Console.Write("1");
                if ((res3 & i) == 0) Console.Write("0");
            }
            Console.WriteLine("\n");

            Console.WriteLine("encode-decode using bitwise XOR");
            char ch1 = 'H';
            char ch2 = 'i';
            char ch3 = '!';
            int key = 15;
            Console.WriteLine("original msg=" + ch1 + ch2 + ch3);
            //encode
            ch1 = (char)(ch1 ^ key);
            ch2 = (char)(ch2 ^ key);
            ch3 = (char)(ch3 ^ key);
            Console.WriteLine("encode msg=" + ch1 + ch2 + ch3);
            //decode
            ch1 = (char)(ch1 ^ key);
            ch2 = (char)(ch2 ^ key);
            ch3 = (char)(ch3 ^ key);
            Console.WriteLine("decode msg=" + ch1 + ch2 + ch3);
        }
        
        //bca
        {
            Console.WriteLine("Bitwise Operator(&,|,^,~,<<,>>)");
            // 0000 0110 - 6
            // 0000 0001 - 1
            // 0000 0000 - 0
            sbyte oe = 6;
            if ((oe & 1) != 0) Console.WriteLine(oe + " is odd no,");
            if ((oe & 1) == 0) Console.WriteLine(oe + " is even no,");
            Console.WriteLine();

            Console.WriteLine("show binary number");
            // 0000 1111 - 15
            // 0000 1000 - 8
            // 0000 1000 - 8
            int sb = 15;
            for (int i = 128; i > 0; i /= 2)
            {
                if ((sb & i) != 0) Console.Write("1");
                if ((sb & i) == 0) Console.Write("0");
            }
            Console.WriteLine();
            Console.WriteLine("Bitwise Not Operator");
            // 0000 1010 - 10
            //~1111 0101 - ~10
            sbyte no = 10;
            no = (sbyte)~no;
            for (int i = 128; i > 0; i /= 2)
            {
                if ((no & i) != 0) Console.Write("1");
                if ((no & i) == 0) Console.Write("0");
            }
            Console.WriteLine();

            Console.WriteLine("Bitwise AND");
            // 0000 1010 - 10
            // 0000 0111 - 7
            //&0000 0010 - 2
            sbyte v1 = 10, v2 = 7, r1;
            r1 = (sbyte)(v1 & v2);
            for (int i = 128; i > 0; i /= 2)
            {
                if ((r1 & i) != 0) Console.Write("1");
                if ((r1 & i) == 0) Console.Write("0");
            }
            Console.WriteLine();

            Console.WriteLine("Bitwise OR");
            // 0000 1010 - 10
            // 0000 0111 - 07
            //|0000 1111 - 15
            int v3 = 10, v4 = 7, r2;
            r2 = v3 | v4;
            for (int i = 128; i > 0; i /= 2)
            {
                if ((r2 & i) != 0) Console.Write("1");
                if ((r2 & i) == 0) Console.Write("0");
            }
            Console.WriteLine();

            Console.WriteLine("Bitwise XOR");
            // 0000 1010 - 10
            // 0000 0111 - 7
            //^0000 1101 - 13
            int v5 = 10, v6 = 7, r3;
            r3 = v5 ^ v6;
            for (int i = 128; i > 0; i /= 2)
            {
                if ((r3 & i) != 0) Console.Write("1");
                if ((r3 & i) == 0) Console.Write("0");
            }
            Console.WriteLine();

            Console.WriteLine("Bitwise Shift Left");
            //  0000 0001 - 1
            //<<0001 0000 - 1<<4
            int sl = 1;
            sl = sl << 4;
            for (int i = 128; i > 0; i /= 2)
            {
                if ((sl & i) != 0) Console.Write("1");
                if ((sl & i) == 0) Console.Write("0");
            }
            Console.WriteLine();

            Console.WriteLine("Bitwise Shift Right");
            //  1000 0000 - 128
            //<<0000 1000 - 1>>4
            int sr = 128;
            sr = sr >> 4;
            for (int i = 128; i > 0; i /= 2)
            {
                if ((sr & i) != 0) Console.Write("1");
                if ((sr & i) == 0) Console.Write("0");
            }
            Console.WriteLine();

            Console.WriteLine("encode-decode using Bitwise XOR");
            // em = om ^ key
            // om = em ^ key
            char ch1 = 'H';
            char ch2 = 'I';
            char ch3 = '!';
            int key = 20;
            Console.WriteLine("Original Message - " + ch1 + ch2 + ch3);
            ch1 = (char) (ch1 ^ key);
            ch2 = (char) (ch2 ^ key);
            ch3 = (char) (ch3 ^ key);
            Console.WriteLine("Encoded Message - " + ch1 + ch2 + ch3);
            ch1 = (char)(ch1 ^ key);
            ch2 = (char)(ch2 ^ key);
            ch3 = (char)(ch3 ^ key);
            Console.WriteLine("Decoded Message - " + ch1 + ch2 + ch3);
        }
    }
}