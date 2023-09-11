
using System;

namespace Practical1a
{
  class Prac1a
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter first integers:");
      int integer1 = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter second integers:");
       int integer2 = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter third integers:");
       int integer3 = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter fourth integers:");
       int integer4 = Convert.ToInt32(Console.ReadLine());
       int result= integer1*integer2*integer3*integer4;
      Console.WriteLine("Your product is: " + result);
    }
  }
}

