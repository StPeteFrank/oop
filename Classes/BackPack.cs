using System;

namespace Oop.Classes
{
  public class BackPack
  {
    public string Color { get; set; }
    public string Owner { get; set; }
    public int NumberOfItems { get; set; } = 0;
    public int MaxNumberOfItems { get; set; }

    public BackPack(string color, string owner, int maxItems)
    {
      Color = color;
      Owner = owner;
      MaxNumberOfItems = maxItems;
    }
  }
}