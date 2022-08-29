using System;
class CallConstByAnotherConst
{
    int height, width;
    public CallConstByAnotherConst() : this(10, 20)
    {
        Console.WriteLine("zero argument constructor");
    }
    public CallConstByAnotherConst(int h, int w)
    {
        height = h;
        width = w;
        Console.WriteLine("two argument constructor height={0}, width={1}",height,width);
    }
}
class Program
{
    static void Main()
    {
        CallConstByAnotherConst c1 = new CallConstByAnotherConst();
    }
}