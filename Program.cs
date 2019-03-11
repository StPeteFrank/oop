using System;

namespace oop
{
  class Program
  {

    // Model real world data inside our code

    // Store points
    /*
    Point has:
        latitude
        longitude
        label
     */

    public class Coordinate
    {
      public decimal Latitude { get; set; }
      public decimal Longitude { get; set; }
      public string Label { get; set; }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
