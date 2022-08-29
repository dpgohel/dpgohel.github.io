using System;
class OptionalParameter
{
    int height, width;
    public void test(int h, int w = 20)
    {
        height = h;
        width = w;
        Console.WriteLine("height={0}, width={1}, area={2}", height, width, (height * width));
    }
}
class Program
{
    static void Main()
    {
        OptionalParameter o1 = new OptionalParameter();
        o1.test(10, 15);
        o1.test(20);
    }
}