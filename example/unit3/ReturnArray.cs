using System;
class ReturnArray
{
    public int[] test(int temp, out int size)
    {
        int[] even = new int[temp];
        int j=0;
        for (int i = 1; i <= temp; i++)
        {
            if (i % 2 == 0)
            {
                even[j] = i;
                j++;
            }
        }
        size = j;
        return even;
    }
}
class Program
{
    static void Main()
    {
        ReturnArray r1 = new ReturnArray();
        int[] evenresult;
        int size;
        evenresult = r1.test(50, out size);
        for (int i = 0; i < size; i++)
        {
            Console.Write(evenresult[i] + ",");
        }
    }
}