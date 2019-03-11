using System;

namespace Oop.Classes
{
  public class BackPack
  {
    public string Color { get; set; }
    public string Owner { get; set; }
    public int NumberOfItems { get; set; } = 0;
    public int MaxNumberOfItems { get; set; }

    public BackPack(string color, string owner, int numberOfItems, int maxItems)
    {
      Color = color;
      Owner = owner;
      NumberOfItems = numberOfItems;
      MaxNumberOfItems = maxItems;
    }

    public int AddItem()
    {
      if (NumberOfItems < MaxNumberOfItems)
      {
        NumberOfItems++;
        return NumberOfItems;
      }
      else
      {
        // throw new Exception("Backpack overflow.");
        return NumberOfItems;
      }
    }
    public int RemoveItem()
    {
      if (NumberOfItems > 0)
      {
        NumberOfItems--;
      }
      return NumberOfItems;
    }
    public override string ToString()
    {
      return $"{Owner}, {Color}, {NumberOfItems}/{MaxNumberOfItems}";
    }

  }
}