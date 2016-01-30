using UnityEngine;
using System.Collections;


public enum YearTraits { Kids = 0, Rain, Crops, Sunshine, Health }
//public enum BadTraits { NoKids = 0, Drought, Locust, Cold, Plague }
public enum ViligerTraits { Virgin = 0, Killer, OldMan, Parent, Gipsy }


public static class TraitsMap
{
    static YearTraits GetGoodTrait(ViligerTraits trait)
    {
        var index = (int)trait;
        return (YearTraits)index;
    }

}