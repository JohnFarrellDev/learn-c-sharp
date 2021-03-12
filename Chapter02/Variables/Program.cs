using System;
using System.Xml;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {
      object height = 1.80;
      object name = "John";
      Console.WriteLine($"{name} is {height} meters tall");
      // int length1 = name.length; compiler error
      int length2 = ((string)name).Length;
      // int length3 = ((string)height).Length; runtime error, double can not cast to string
      Console.WriteLine($"{name} has {length2} characters");

      dynamic anotherName = "Ana"; // we lose intellisense plus compile time error checking
      int length = anotherName.Length;

      var population = 66_000_000; // 66 million in UK
      var canBeLarge = 1_000_000_000_000L; // 1 trillion
      var weight = 1.88; // in kilograms
      var price = 4.99M; // in pounds sterling
      var fruit = "Apples"; // strings use double-quotes
      var letter = 'Z'; // chars use single-quotes
      var happy = true; // Booleans have value of true or false

      XmlDocument xml1 = new XmlDocument();
      XmlDocument xml2 = new(); // introduced in C# 9.0, just a shorthand for above

      Console.WriteLine($"default(int) = {default(int)}");
      Console.WriteLine($"default(bool) = {default(bool)}");
      Console.WriteLine($"default(DateTime) = {default(DateTime)}");
      Console.WriteLine($"default(string) = {default(string)}");
    }
  }
}
