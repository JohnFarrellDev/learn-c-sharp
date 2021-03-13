using System;

namespace Debugging
{
  class Program
  {
    static void Main(string[] args)
    {
      double a = 4.5;
      double b = 2.5;
      Console.WriteLine($"{a} + {b} = {add(a, b)}");
    }

    static double add(double a, double b) => a + b;
  }
}
