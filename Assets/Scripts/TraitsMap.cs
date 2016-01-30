using UnityEngine;
using System.Collections;


public enum GoodTraits { Kids = 0, Rain, Crops, Sunshine, Health }
public enum BadTraits { NoKids = 0, Drought, Locust, Cold, Plague }
public enum ViligerTraits { Virgin = 0, Killer, OldMan, Parent, Gipsy }


public static class TraitsMap
{
    static GoodTraits GetGoodTrait(BadTraits trait)
    {
        var index =(int)trait;
        return (GoodTraits)index;
    }

    static BadTraits GetBadTrait(GoodTraits trait)
    {
        var index = (int)trait;
        return (BadTraits)index;
    }

    static GoodTraits GetGoodTrait(ViligerTraits trait)
    {
        var index = (int)trait;
        return (GoodTraits)index;
    }

}