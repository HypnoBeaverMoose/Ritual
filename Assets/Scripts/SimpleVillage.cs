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

    public int Year { get; private set; }

    public int Population { get; private set; }

    public string YearText { get { return yearText; } }

    private VillageTrait[] traits;
    private string yearText = "";
    public SimpleVillage(int startPopulation)
    {
        Year = 0;
        traits = new VillageTrait[Enum.GetValues(typeof(YearTraits)).Length];
        for (int i = 0; i < traits.Length; i++)
        {
            traits[i] = new VillageTrait();
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
        Year++;
        Population -= UnityEngine.Random.Range(0, 20);
        yearText = "";
        foreach (var trait in traits)
        {
            switch (trait.Trait)
            {
                case YearTraits.Kids:
                    if (trait.Good)
                    {
                        yearText += "There were more kids.";
                    }
                    else
                    {
                        yearText += "There were less kids.";
                    }
                    break;
                case YearTraits.Rain:
                    if (trait.Good)
                    {
                        yearText += "There was more Rain.";
                    }
                    else
                    {
                        yearText += "There were less Rain.";
                    }
                    break;
                case YearTraits.Crops:
                    if (trait.Good)
                    {
                        yearText += "There was good Crops.";
                    }
                    else
                    {
                        yearText += "There there was Pestilance.";
                    }
                    break;
                case YearTraits.Sunshine:
                    if (trait.Good)
                    {
                        yearText += "There was Sunshine.";
                    }
                    else
                    {
                        yearText += "There was no Sunshine.";
                    }
                    break;
                case YearTraits.Health:
                    if (trait.Good)
                    {
                        yearText += "People were Healthy.";
                    }
                    else
                    {
                        yearText += "There was a Plague.";
                    }
                    break;
                default:
                    break;
            }
            yearText += "\n";

        }
    }



    public void Sacrifice(IVilliger villiger)
    {
        throw new NotImplementedException();
    }

    public IVilliger GetNextOffering()
    {
        throw new NotImplementedException();
    }
}