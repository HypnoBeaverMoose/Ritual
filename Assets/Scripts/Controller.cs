using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Random = UnityEngine.Random;
using System;

public class Controller : MonoBehaviour {

    public Text populationText;
    public Text yearText;
    public GameObject viligersParent;
    private IVillage village;    
    public int Population {get; set;}
    public object Traits { get; set; }
    
    void Start () {
        village = new SimpleVillage(100);
        GenerateYear();
	}

    public void OnViligerClicked(ViligerTraits trait)
    {
        (village as SimpleVillage).SetTrait(TraitsMap.GetYearTrait(trait), true); ;
        for (int i = 0; i < viligersParent.transform.childCount; i++)
		{
            Destroy(viligersParent.transform.GetChild(i).gameObject);
        }

        MessUpTrait(TraitsMap.GetYearTrait(trait));
        GenerateYear();
    }

    public void GenerateYear()
    {
        int length = Enum.GetValues(typeof(ViligerTraits)).Length;
        for (int i = 0; i < length; i++)
        {
            var viliger = ViligerGenerator.Instance.CreateViliger((ViligerTraits)i);
            viliger.transform.SetParent(viligersParent.transform, false);
            viliger.OnViligerSelected += OnViligerClicked;
        }
        village.UpdateVillage();
        yearText.text = village.YearText;
        populationText.text = village.Population.ToString();

    }
    private void MessUpTrait(YearTraits locked)
    {
        int index = (int)locked;
        int rand = Random.Range(0, Enum.GetValues(typeof(YearTraits)).Length);
        while (rand == index)
        {
            rand = Random.Range(0, Enum.GetValues(typeof(YearTraits)).Length);
        }
        (village as SimpleVillage).SetTrait((YearTraits)rand, false);
    }

}
