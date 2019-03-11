using System;

namespace Oop.Classes
{
  public class Pet
  {
    public string Name { get; set; }     // Attributes
    public string Breed { get; set; }
    public DateTime Birthday { get; set; } = DateTime.Now;
    public int Age { get; set; } = 0;
    public bool IsAdopted { get; set; } = false;
    public string OwnerName { get; set; }

    public override string ToString()
    {
      return ($"{OwnerName} has adopted {Name} that is a {Breed}");
    }

    public Pet(string name, string breed)      /// Constructor
    {
      Name = name;
      Breed = breed;

    }
    public Boolean Adopt(string Owner)       /// Method
    {
      IsAdopted = true;
      OwnerName = Owner;
      return IsAdopted;
    }
  }
}
