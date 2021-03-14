namespace Packt.Shared
{
  public partial class Person
  {
    public string Origin
    {
      get
      {
        return $"{this.Name} was born on {this.HomePlanet}";
      }
    }

    public string FavouriteIceCream { get; set; }

    public string Greeting => $"{Name} says hello";

    public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

    private string favouritePrimaryColour;
    public string FavouritePrimaryColor
    {
      get
      {
        return favouritePrimaryColour;
      }
      set
      {
        switch (value.ToLower())
        {
          case "red":
          case "blue":
          case "green":
            favouritePrimaryColour = value;
            break;
          default:
            throw new System.ArgumentException($"{value} is not a primary colour");
        }
      }
    }

    public Person this[int index]
    {
      get
      {
        return this.Children[index];
      }
      set
      {
        this.Children[index] = value;
      }
    }
  }
}