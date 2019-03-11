using System;

namespace Oop.Classes
{
  public class Coordinate
  {
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public string Label { get; set; }

    public override string ToString()
    {
      return $"{Label} located at {Latitude}, {Longitude}.";
    }
  }
}