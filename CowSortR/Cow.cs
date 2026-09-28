namespace CowSortR;
using System;
using System.Collections.Generic;
public class Cow : IEquatable<Cow>, IComparable<Cow>
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }

    public Cow(string name, string colour, int age)
    {
        Name = name;
        Colour = colour;
        Age = age;
    }
    
    public bool Equals(Cow other)
    {
        if (other == null) return false;
        return Name == other.Name && Colour == other.Colour && Age == other.Age;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Cow);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Colour, Age);
    }

    public int CompareTo(Cow other)
    {
        if (other == null) return 1;
        int namecomp = string.Compare(this.Name, other.Name);
        if (namecomp != 0) return namecomp;
        int colourcomp = string.Compare(this.Colour, other.Colour);
        if (colourcomp != 0) return colourcomp;
        return other.Age.CompareTo(this.Age);
    }

    public override string ToString()
    {
        return $"{Name},Farbe: {Colour},{Age}:Jahre";
    }
}


