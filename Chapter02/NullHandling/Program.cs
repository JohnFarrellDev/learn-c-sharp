using System;

namespace NullHandling
{

  class Animal
  {
    public string Name = string.Empty;
  }

  class Address
  {
    public string? Building;
    public string Street = string.Empty;
    public string City = string.Empty;
    public string Region = string.Empty;

    public Animal Animal = new Animal();

    public Animal? Animal2 = new Animal();

    public void Test()
    {
      if (Animal.Name.Length > -1)
      {
        Console.WriteLine("Animal reference type cannot be null so no null check required");
      }
    }

    public void Test2()
    {
      if (Animal2 != null)
      {
        if (Animal2.Name.Length > -1)
        {
          Console.WriteLine("Animal2 reference type is nullable so null check required");
        }
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      int thisCannotBeNull = 4;
      // thisCannotBeNull = null; compile error, value types cannot be assigned null
      int? thisCanBeNull = null;
      Console.WriteLine(thisCanBeNull);
      Console.WriteLine(thisCanBeNull.GetValueOrDefault());
      thisCanBeNull = 7;
      Console.WriteLine(thisCanBeNull);
      Console.WriteLine(thisCanBeNull.GetValueOrDefault());

      Address address = new Address();
      address.Building = null;
      address.City = "london";

      if (address.City.Length > 5)
      {
        Console.WriteLine("Does not need null reference check first on non-nullabe value type when nullable is enabled since C# 8.0");
      }

      if (address.Building != null)
      {
        if (address.Building.Length > 5)
        {
          Console.WriteLine("need to do a null reference check first on nullable value type");
        }
      }

      address.Test();
      address.Test2();

      string? randomName = null;
      // int randomNameLengthNoCheck = randomName.Length; MarshalByRefObject throw null pointer exception
      int? randomNameLengthNoCheck = randomName?.Length; // if randomName is null then assign null to randomNameLengthNoCheck
      int? randomNameLengthNoCheckCoalescing = randomName?.Length ?? 3; //if randomName is null then assign 3
      Console.WriteLine(randomNameLengthNoCheckCoalescing);
    }
  }
}
