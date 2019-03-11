using System;
using Oop.Classes;

namespace oop
{
  class Program
  {
    static void Main(string[] args)
    {
      var point = new Coordinate();

      point.Latitude = (decimal)-82.12345;
      point.Longitude = (decimal)-27.98765;
      point.Label = "Somewhere over the rainbow.";

      Console.WriteLine(point);

      var cat = new Pet("", "");

      cat.Name = "Fluffer";
      cat.Breed = "Tabby";
      cat.Adopt("Mike");
      Console.WriteLine(cat);

      var dog = new Pet("Spot", "Shepard");
      dog.Adopt("Janie");

      Console.WriteLine($"{dog.OwnerName} has adopted {dog.Name} which is a {dog.Breed}. They are currently located at {point.Label}");

      var myPack = new BackPack("Red", "Frank", 4, 6);
      var campingPack = new BackPack("Blue", "Tony", 8, 12);

      Console.WriteLine($"{myPack.Owner} has a {myPack.Color} back pack and it holds {myPack.MaxNumberOfItems} items");
      Console.WriteLine(campingPack);


    }
  }
}
