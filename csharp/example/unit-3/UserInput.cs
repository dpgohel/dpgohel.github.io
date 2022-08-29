using System;
class UserInput
{
    static void Main()
    {
        int x, y;
        x = Convert.ToInt32(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        if (x > y)
            Console.WriteLine(x + " is big");
        else
            Console.WriteLine(y + " is big");
    }
}