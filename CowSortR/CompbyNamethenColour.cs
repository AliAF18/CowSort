namespace CowSortR;
using System;
using System.Collections.Generic;

public class CompbyNamethenColour: IComparer<Cow>
{
    
    public int Compare(Cow x, Cow y)
    {
        if (x == null || y == null) return 0;
        int resultcomp = string.Compare(x.Name, y.Name);
        if (resultcomp != 0)
        {
            resultcomp = y.Colour.CompareTo(x.Colour);
        }
        return resultcomp;
    }
}