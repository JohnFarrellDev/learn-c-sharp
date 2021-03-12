using System;

namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      uint naturalNumber = 23;
      int integerNumber = -23;
      float realNumber = 2.3F;
      double anotherRealNumber = 2.3;

      int underScoreNotation = 2_000_000;
      int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
      int hexadecimalNotation = 0x_001E_8480;

      Console.WriteLine($"{underScoreNotation == binaryNotation}");
      Console.WriteLine($"{underScoreNotation == hexadecimalNotation}");

      Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");
      Console.WriteLine($"double uses {sizeof(double)} bytes and can store values in the range {double.MinValue:N0} to {double.MaxValue:N0}");
      Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store values in the range {decimal.MinValue:N0} to {double.MaxValue:N0}");

      double a = 0.1;
      double b = 0.2;

      Console.WriteLine("Using doubles:");
      if (a + b == 0.3)
      {
        Console.WriteLine($"{a} + {b} equals 0.3");
      }
      else
      {
        Console.WriteLine($"{a} + {b} does NOT equal 0.3");
      }

      Console.WriteLine($"This occurs due to floating point maths, smallest increment for a double is {double.Epsilon}");

      decimal c = 0.1M;
      decimal d = 0.2M;
      Console.WriteLine("Using decimals:");
      if (c + d == 0.3M)
      {
        Console.WriteLine($"{c} + {d} equals 0.3");
      }
      else
      {
        Console.WriteLine($"{c} + {d} does NOT equal 0.3");
      }

    }
  }
}
