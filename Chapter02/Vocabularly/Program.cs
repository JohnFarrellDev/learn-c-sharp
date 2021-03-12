using System;
using System.Linq;
using System.Reflection;

namespace Vocabulary
{
  class Program
  {
    static void Main(string[] args)
    {
      foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
      {
        var a = Assembly.Load(new AssemblyName(r.FullName));

        int methodCount = 0;

        System.Data.DataSet dataSet;
        System.Net.Http.HttpClient client;

        foreach (var t in a.DefinedTypes)
        {
          methodCount += t.GetMethods().Count();
        }

        string x = "hello world";

        Console.WriteLine(
          "{0:N0} types with {1:N0} methods in {2} assembly",
          arg0: a.DefinedTypes.Count(),
          arg1: methodCount,
          arg2: r.Name
        );
      }
    }
  }
}
