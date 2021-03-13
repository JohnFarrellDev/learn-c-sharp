using System;
using static System.Convert;

namespace CastingConverting
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 10;
      double b = a;

      Console.WriteLine(b);

      double c = 9.8;
      // int d = c; implicit conversion has compiler error due to potential data loss
      int d = (int)c;
      Console.WriteLine(d);

      long e = 10;
      int f = (int)e;
      Console.WriteLine($"e if {e:N0} and f is {f:N0}");

      e = long.MaxValue;
      f = (int)e;
      Console.WriteLine($"e if {e:N0} and f is {f:N0}");

      double g = 9.8;
      int h = ToInt32(g);
      Console.WriteLine($"g is {g} and h is {h}");

      double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
      foreach (double i in doubles)
      {
        Console.WriteLine($"ToInt({i}) is {ToInt32(i)}");
      }
      // uses "bankers" rule, alternates rounding up or down .5, be warned

      foreach (double j in doubles)
      {
        string formattedString = string.Format(
          "Math.Round({0}), 0, MidpointRounding.AwayFromZero is {1}",
          arg0: j,
          arg1: Math.Round(value: j, digits: 0, mode: MidpointRounding.AwayFromZero)
        );
        Console.WriteLine(formattedString);
      }
      // using round up from .5 rule

      int number = 42;
      Console.WriteLine(number.ToString());

      bool boolean = true;
      Console.WriteLine(boolean.ToString());

      DateTime now = DateTime.Now;
      Console.WriteLine(now.ToString());

      object uhhh = new object();
      Console.WriteLine(uhhh.ToString());

      byte[] binaryObject = new byte[128];
      new Random().NextBytes(binaryObject);
      Console.WriteLine("Binary object as bytes");
      for (int index = 0; index < binaryObject.Length; index++)
      {
        Console.WriteLine($"{binaryObject[index]:X}");
      }
      Console.WriteLine();

      string encoded = Convert.ToBase64String(binaryObject);
      Console.WriteLine($"Binary object as Base64: {encoded}");

      int age = int.Parse("27");
      DateTime birthday = DateTime.Parse("11 June 1993");
      Console.WriteLine($"I was born {age} years ago");
      Console.WriteLine($"My Birthday is {birthday}");
      Console.WriteLine($"My Birthday is {birthday:D}");

      try
      {
        int count = int.Parse("abc");
      }
      catch (FormatException exception)
      {
        Console.WriteLine(exception.Message);
      }
      catch (Exception exception)
      {
        Console.WriteLine("Catches all exceptions if not caught by more specific previous exception");
      }

      Console.Write("Hot old are you");
      string input = Console.ReadLine();

      if (int.TryParse(input, out age))
      {
        Console.WriteLine($"Your age is {age}");
      }
      else
      {
        Console.WriteLine("input needs to be a valid integer");
      }
    }
  }
}
