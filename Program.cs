using System;

namespace oop
{
  class Program
  {
    public class Coordinate
    {
      public decimal Latitude { get; set; }
      public decimal Longitude { get; set; }
      public string Label { get; set; }
    }

    static void Main(string[] args)
    {
      var point = new Coordinate();

      point.Latitude = (decimal)-82.12345;
      point.Latitude = (decimal)-27.98765;
      point.Label = "Somewhere over the rainbow.";
    }
  }
}
