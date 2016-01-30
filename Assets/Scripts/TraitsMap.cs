using UnityEngine;
using System.Collections;


[System.Flags]
public enum YearTraits { Kids = 0, Rain = 1, Crops = 2, Sunshine = 4, Health = 8}

public enum ViligerTraits { Virgin = 0, Killer, OldMan, Parent, Gipsy }


public static class TraitsMap
{
    public static YearTraits GetYearTrait(ViligerTraits trait)
    {
        var index = (int)trait;
        return (YearTraits)index;
    }

}