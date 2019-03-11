using System;

namespace Oop.Classes
{
  public class BackPack
  {
    public string Color { get; set; }
    public string Owner { get; set; }
    public int NumberOfItems { get; set; } = 0;
    public int MaxOfNumberOfItems { get; set; }
  }
}