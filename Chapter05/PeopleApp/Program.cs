using System;
using Packt.Shared;
using PacktLibrary9;
using static System.Console;

namespace PeopleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Person bob = new Person();
      bob.Name = "bob";
      bob.DateOfBirth = new DateTime(1972, 12, 25);
      bob.FavoriteWonder = WondersOfTheWorld.HangingGardens;
      bob.BucketList = WondersOfTheWorld.TempleOfArtemis | WondersOfTheWorld.ColossusOfRhodes;
      bob.Children.Add(new Person() { Name = "Tom" });
      bob.Children.Add(new Person() { Name = "Joe" });

      var alice = new Person
      {
        Name = "Alice",
        DateOfBirth = new DateTime(1984, 04, 12),
        FavoriteWonder = WondersOfTheWorld.TempleOfArtemis
      };

      WriteLine(format: "{0}'s favourite wonder is {1}. Its integer is {2}.", arg0: bob.Name, arg1: bob.FavoriteWonder, arg2: (int)bob.FavoriteWonder);
      WriteLine(format: "{0}'s bucket list is {1} or as an int {2}.", arg0: bob.Name, arg1: bob.BucketList, arg2: (int)bob.BucketList);

      WriteLine($"{bob.Name} has {bob.Children.Count} children:");
      foreach (Person child in bob.Children)
      {
        WriteLine(child.Name);
      }



      BankAccount.InterestRate = 0.1M;
      var JohnAccount = new BankAccount();

      bob.WriteToConsole();
      WriteLine(bob.GetOrigin());

      (string, int) fruit = bob.GetFruit();
      WriteLine($"{fruit.Item1}, {fruit.Item2} amount");

      var fruitNamed = bob.GetNamedFruit();
      WriteLine($"{fruitNamed.Name}, {fruitNamed.Number} amount");

      var thing1 = ("Neville", 4);
      WriteLine($"{thing1.Item1} has {thing1.Item2} children");

      var thing2 = (bob.Name, bob.Children.Count);
      WriteLine($"{thing2.Name} has {thing2.Count} children");

      (string name, int age) tupleWithFields = Person.GetPerson();
      // can destructure tuple into its fields on assignment
      (string name, int age) = Person.GetPerson();

      WriteLine(bob.SayHello());
      WriteLine(bob.SayHello("Margie"));

      WriteLine(bob.OptionalParameters());
      WriteLine(bob.OptionalParameters(number: 3.14));
      WriteLine(bob.OptionalParameters("drive", 3.14, false));

      int a = 10;
      int b = 20;
      int c = 30;
      WriteLine($"Before: A = {a}, B = {b}, C = {c}");
      bob.PassingParameters(a, ref b, out c);
      WriteLine($"After: A = {a}, B = {b}, C = {c}");

      var sam = new Person()
      {
        Name = "Sam",
        DateOfBirth = new DateTime(1965, 11, 05)
      };
      WriteLine(sam.Origin);
      WriteLine(sam.Age);
      WriteLine(sam.Greeting);

      sam.FavouriteIceCream = "Chocolate";
      WriteLine(sam.FavouriteIceCream);

      sam.Children.Add(new Person("Beth"));
      sam.Children.Add(new Person("Ana"));

      WriteLine(sam[0].Name);
      WriteLine(sam[1].Name);

      object[] passengers = {
        new FirstClassPassenger { AirMiles = 1_419},
        new FirstClassPassenger { AirMiles = 16_562 },
        new BusinessClassPassenger(),
        new CoachClassPassenger {CarryOnKG = 25.7},
        new CoachClassPassenger {CarryOnKG = 0},
      };

      foreach (object passenger in passengers)
      {
        decimal flightCost = passenger switch
        {
          FirstClassPassenger p => p.AirMiles switch
          {
            > 35000 => 1500M,
            > 15000 => 1750M,
            _ => 2000M
          },
          BusinessClassPassenger _ => 1000M,
          CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
          CoachClassPassenger _ => 650M,
          _ => 800M
        };

        WriteLine($"Flight costs {flightCost:C} for {passenger}");
      }
    }
  }
}
