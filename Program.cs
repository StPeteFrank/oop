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

      var cat = new Pet("Fluffy", "Russian Blue");

      cat.Name = "Fluffer";
      cat.Breed = "Tabby";
      cat.OwnerName = "John";

      cat.Adopt("Mike");
      Console.WriteLine(cat);
    }
  }
}
