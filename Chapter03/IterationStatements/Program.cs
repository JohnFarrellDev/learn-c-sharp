using System;

namespace IterationStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 0;
      while (x < 10)
      {
        Console.WriteLine(x);
        x++;
      }

      // string passWord = string.Empty;
      // do
      // {
      //   Console.WriteLine("Enter your password:");
      //   passWord = Console.ReadLine();
      // } while (passWord != "Pa$$w0rd");
      // Console.WriteLine("Correct");

      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(i);
      }

      string[] names = { "John", "Ana", "Mikey", "Sandra" };
      foreach (string name in names)
      {
        Console.WriteLine($"{name} has {name.Length} characters");
      }
    }
  }
}
