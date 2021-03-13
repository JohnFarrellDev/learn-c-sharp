using System;
using System.IO;

namespace SelectionStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      bool truthy = true;
      bool falsey = false;

      if (truthy)
      {
        Console.WriteLine("inside the expression that evaluates to true");
      }
      else if (falsey)
      {
        Console.WriteLine("inside the expression that evaluates to false");
      }
      else
      {
        Console.WriteLine("None of the other expressions are true");
      }

      if (args.Length == 0)
      {
        Console.WriteLine("there were no console arguments provided");
      }
      else
      {
        Console.WriteLine($"{args.Length} arguments provided");
      }

      object o = 3; // if this is "3" os is int == false
      int j = 4;

      if (o is int i) // if o can be cast to int, evaluate to true and apply cast value to i
      {
        Console.WriteLine($"{i} x {j} = {i * j}");
      }
      else
      {
        Console.WriteLine("o is not an int so it can not be used to multiply");
      }

    A_label:
      {
        int number = new Random().Next(1, 7);
        Console.WriteLine($"My random number is {number}");

        switch (number)
        {
          case 1:
            Console.WriteLine("one");
            break;
          case 2:
            Console.WriteLine("two");
            goto case 1;
          case 3:
          case 4:
            Console.WriteLine("Three or four");
            goto case 1;
          case 5:
            System.Threading.Thread.Sleep(500);
            goto A_label;
          default:
            Console.WriteLine("Default");
            break;
        }
      }

      string path = @"..\";
      Console.Write("Press R for readonly or W for write");
      ConsoleKeyInfo key = Console.ReadKey();
      Console.WriteLine();
      Stream s = null;
      if (key.Key == ConsoleKey.R)
      {
        s = File.Open(
          Path.Combine(path, "file.txt"),
          FileMode.OpenOrCreate,
          FileAccess.Read
        );
      }
      else
      {
        s = File.Open(
          Path.Combine(path, "file.txt"),
          FileMode.OpenOrCreate,
          FileAccess.Write
        );
      }
      string message = string.Empty;
      switch (s)
      {
        case FileStream writeableFile when s.CanWrite:
          message = "The stream is a file that can be written to";
          break;
        case FileStream readOnlyFile:
          message = "The stream is a read-only file";
          break;
        case MemoryStream memoryStream:
          message = "The stream is a memory address";
          break;
        default:
          message = "the stream is some other type";
          break;
        case null:
          message = "the stream is null";
          break;
      }
      Console.WriteLine(message);

      message = s switch
      {
        FileStream writeAbleFile when s.CanWrite => "The stream is a file I can write to",
        FileStream readOnlyFile => "The stream is a read-only file",
        MemoryStream ms => "The stream is a memory address",
        null => "The stream is null",
        _ => "The stream is some other type"
      };
      Console.WriteLine(message);

    }
  }
}
