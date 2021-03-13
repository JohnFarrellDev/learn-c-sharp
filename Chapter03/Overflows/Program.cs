using System;

namespace Overflows
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = int.MaxValue - 1;
      Console.WriteLine($"initial value is {x}");
      x++;
      Console.WriteLine($"after incrementing value is {x}");
      x++;
      Console.WriteLine($"after incrementing value is {x}");
      x++;
      Console.WriteLine($"after incrementing value is {x}");

      checked
      {
        try
        {
          x = int.MaxValue - 1;
          Console.WriteLine($"initial value is {x}");
          x++;
          Console.WriteLine($"after incrementing value is {x}");
          x++;
          Console.WriteLine($"after incrementing value is {x}");
          x++;
          Console.WriteLine($"after incrementing value is {x}");
        }
        catch (OverflowException exception)
        {
          Console.WriteLine($"Value overflowed but I caught the exception!");
        }
      }

      unchecked
      {
        int y = int.MaxValue + 1;
        Console.WriteLine($"Initial value of y is {y}");
        y--;
        Console.WriteLine($"After decrementing y is {y}");
        y--;
        Console.WriteLine($"After decrementing y is {y}");
      }
    }
  }
}
