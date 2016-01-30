using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Random = UnityEngine.Random;
using System;

public class Controller : MonoBehaviour 
{
    public UIVilliger[] villigerSpots;

    public Text populationText;
    public Text yearText;
    public int StartPopulation;

    private IVillage village;    
    
    void Start () 
    {
        village = new SimpleVillage(100);
        NextYear();
	}

    public void OnViligerClicked(UIVilliger villiger)
    {
        village.Sacrifice(villiger.Villiger);
        NextYear();
    }

    public void NextYear()
    {
        foreach (var spot in villigerSpots)
        {
            spot.Villiger = village.GetNextOffering();
            spot.Image = PickVilligerSprite(spot.Villiger);
        }
        village.UpdateVillage();
        yearText.text = village.YearText;
        populationText.text = village.Population.ToString();
    }

    public Sprite PickVilligerSprite(IVilliger villiger)
    {
        return new Sprite();
    }
}
