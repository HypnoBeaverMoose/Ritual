using UnityEngine;
using System.Collections;

public interface IVillage 
{

    int Year { get; }

    int Population { get; }

    string YearText { get; }

    void Sacrifice(IVilliger villiger);

    IVilliger GetNextOffering();

    void UpdateVillage();
    
}
