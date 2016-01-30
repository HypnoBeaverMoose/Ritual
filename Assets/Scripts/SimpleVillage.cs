using UnityEngine;
using System.Collections;
using System.Linq;

using System;

public class SimpleVillage : IVillage 
{
    private class VillageTrait
    {
        public YearTraits Trait;
        public bool Good;
    }

    public int Population { get; private set; }

    public string YearText { get { return ""; } }


    private VillageTrait[] traits;

    public SimpleVillage(int startPopulation)
    {
        traits = new VillageTrait[Enum.GetValues(typeof(YearTraits)).Length];
        for (int i = 0; i < traits.Length; i++)
        {
            traits[i].Trait = (YearTraits)i;
            traits[i].Good = true;
        }
        Population = startPopulation;
        
    }

    public void SetTrait(YearTraits trait, bool good)
    {
        traits.First(t => t.Trait == trait).Good = good;
    }

    public void UpdateVillage()
    {

    }
}
