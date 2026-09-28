namespace CowSortR;
using System;
using System.Collections.Generic;
 
public class CompbyAgethenName : IComparer<Cow>
{
    
    public int Compare(Cow x, Cow y)
    {
        if (x == null || y == null) return 0;
        
        int result = x.Age.CompareTo(y.Age);
        if (result == 0)
        {
            result = x.Name.CompareTo(y.Name);
        }

        return result;
    }
}