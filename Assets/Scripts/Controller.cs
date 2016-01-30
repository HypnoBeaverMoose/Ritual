using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Controller : MonoBehaviour {

    public Text populationText;
    public Text yearText;
    public GameObject viligersParent;
    
    public int Year { get; set; }
    public int Population {get; set;}
    public object Traits { get; set; }
    
    void Start () {
        Year = 0;
	}

    public void OnViligerClicked(ViligerTraits traits)
    {
         ///modify population
         ///regenerate year;
        Year++;
    }

    public void GenerateYear()
    {
        int length = Enum.GetValues(typeof(ViligerTraits)).Length;
        for (int i = 0; i < length; i++)
        {
            var viliger = ViligerGenerator.Instance.CreateRandomViliger();
            viliger.transform.SetParent(viligersParent.transform, false);
            // add event here;
        }

    }

	// Update is called once per frame
	void Update () {
	
	}


}
