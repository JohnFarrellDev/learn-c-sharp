using System;

namespace Functions
{
  class Program
  {
    static void Main(string[] args)
    {
      PrintFactorials(15);
      RunFib(number: 20);
    }


    static string CardinalToOrdinal(int number)
    {
      switch (number)
      {
        case 11:
        case 12:
        case 13: return $"{number}th";
        default:
          int lastDigit = number % 10;
          string suffix = lastDigit switch
          {
            1 => "st",
            2 => "nd",
            3 => "rd",
            _ => "th"
          };
          return $"{number}{suffix}";
      }
    }

    static void PrintFactorials(int number)
    {
      for (int i = 1; i <= number; i++)
      {
        try
        {
          Console.WriteLine($"{i}! = {Factorial(i)}");
        }
        catch (OverflowException)
        {
          Console.WriteLine($"Factorial of {i} is too big to be stored in an int");
        }
      }
    }

    /// <summary>
    /// Takes an as an input and returns its value as a factorial 
    /// </summary>
    /// <param name="number">Number is any positive integer value</param>
    /// <returns>Integer that represent the factoral value of the input integer</returns>
    static int Factorial(int number)
    {
      if (number < 1)
      {
        return 0;
      }
      if (number == 1)
      {
        return 1;
      }
      checked
      {
        return number * Factorial(number - 1);
      }
    }

    static void RunFib(int number)
    {
      for (int i = 1; i <= number; i++)
      {
        string formattedString = string.Format(
          "The {0} term of the Fibonacci sequence is {1}",
          arg0: CardinalToOrdinal(i),
          arg1: FibFunctional(i)
        );
        Console.WriteLine(formattedString);
      }
    }

    static int FibImperative(int number)
    {
      if (number <= 1)
      {
        return 0;
      }
      if (number == 2)
      {
        return 1;
      }
      return FibImperative(number - 1) + FibImperative(number - 2);
    }

    static int FibFunctional(int number) =>
      number switch
      {
        1 => 0,
        2 => 1,
        _ => FibFunctional(number - 1) + FibFunctional(number - 2)
      };
  }
}
