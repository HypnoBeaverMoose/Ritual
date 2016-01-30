using UnityEngine;
using System.Collections;

public interface IVillage 
{

    int Population { get; }

    string YearText { get; }

    void UpdateVillage();
    
}
