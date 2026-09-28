namespace CowSortR;
using System;
using System.Collections.Generic;
 
public class CompbyAgethenName : IComparer<Cow>
{
    
    public int Compare(Cow x, Cow y)
    {
        if (x == null || y == null) return 0;
        
        int ageComparison = x.Age.CompareTo(y.Age);
        if (ageComparison != 0) return ageComparison;

        return string.Compare(x.Name, y.Name);
    }
}