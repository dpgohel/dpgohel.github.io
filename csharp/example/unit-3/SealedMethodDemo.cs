using System;
class grandparent
{
    public virtual void test() { }
}
class parent : grandparent 
{
    sealed public override void test() { }
}
class child : parent 
{
    //Error 'child.test()': cannot override inherited member 'parent.test()' because it is sealed
    //public override void test() { }
}
class Program
{
    static void Main()
    {
        
    }
}