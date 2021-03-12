using System;

namespace Arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] names;

      names = new string[4];
      names[0] = "John";
      names[1] = "Ana";
      names[2] = "Mikey";
      names[3] = "Sandra";

      for (int i = 0; i < names.Length; i++)
      {
        Console.WriteLine(names[i]);
      }
    }
  }
}
