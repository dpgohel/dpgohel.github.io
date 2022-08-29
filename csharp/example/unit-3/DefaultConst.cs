using System;
class DefaultConst
{
 public int rollno;
 public string name;
 public bool isactive;
 public DefaultConst()
 {
   rollno=11;
   name="Raj";
   isactive=true;
 }
}
class Program
{
 static void Main()
 {
   DefaultConst  c1 = new DefaultConst();
   Console.WriteLine(c1.rollno);
   Console.WriteLine(c1.name);
   Console.WriteLine(c1.isactive);
 }
}