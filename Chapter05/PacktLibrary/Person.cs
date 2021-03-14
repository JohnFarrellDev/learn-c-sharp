using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
  public partial class Person : System.Object
  {
    public string Name;
    public DateTime DateOfBirth;
    public WondersOfTheWorld FavoriteWonder;
    public WondersOfTheWorld BucketList;
    public List<Person> Children = new List<Person>();
    // constant field so cannot change (better practice is read-only)
    public const string Species = "Homo Sapien";

    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;

    public Person() : this("unknown", "Earth")
    {
      // set default values for fields including read-only
      // Name = "unknown";
      // Instantiated = DateTime.Now;
    }

    public Person(string initialName) : this(initialName, HomePlanet: "unknown") { }

    public Person(string initialName, string HomePlanet)
    {
      Name = initialName;
      this.HomePlanet = HomePlanet;
      Instantiated = DateTime.Now;
    }

    public void WriteToConsole()
    {
      WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
    }

    public string GetOrigin() => $"{Name} was born on {HomePlanet}";

    public (string, int) GetFruit() => ("Apples", 5);

    public (string Name, int Number) GetNamedFruit() => (Name: "Apples", Number: 5);

    public static (string Name, int Number) GetPerson() => ("Anything", 42);

    public string SayHello()
    {
      return $"{Name} says hello";
    }

    public string SayHello(string Name)
    {
      return $"{this.Name} says hello to {Name}";
    }

    // public string SayHelloTo(string Name)
    // {
    //   return $"{this.Name} says hello to {Name}";
    // }

    public String OptionalParameters(
      string command = "Run!",
      double number = 0.0d,
      bool active = true
    ) => $"command is {command}, number is {number}, active is {active}";

    public void PassingParameters(int x, ref int y, out int z)
    {
      z = 99;

      x++;
      y++;
      z++;
    }
  }

  // if only storing up to 8 items can save space using byte type as storage instad of int
  // ushort if 16, uint if 32, ulong if 64
  [System.Flags]
  public enum WondersOfTheWorld : byte
  {
    None = 0b_0000_0000,
    Pyramids = 0b_0000_0001,
    HangingGardens = 0b_0000_0010,
    StatueOfZeus = 0b_0000_0100,
    TempleOfArtemis = 0b_0000_1000,
    MausoleumAtHalicarnassus = 0b_0001_0000,
    ColossusOfRhodes = 0b_0010_0000,
    LighthouseOfAlexandria = 0b_0100_0000
  }
}
