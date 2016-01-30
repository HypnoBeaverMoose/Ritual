using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Random = UnityEngine.Random;
using System;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour 
{
    public UIVilliger[] villigerSpots;
    public Sprite[] VilligerSprites;

    public Text populationText;
    public Text yearText;
    public int StartPopulation;
    public float RoundTime;
    private bool allowInput = true;
    private IVillage village;    
    
    void Start () 
    {
        village = new SimpleVillage(100);
        foreach (var spot in villigerSpots)
        {
            spot.OnViligerSelected += OnViligerClicked;
        }
        NextYear();        
	}

    public void OnViligerClicked(UIVilliger villiger)
    {
        village.Sacrifice(villiger.Villiger);
        StartCoroutine(RoundCoroutine(villiger));
    }

    public IEnumerator RoundCoroutine(UIVilliger vill)
    {
        allowInput = false;
        vill.FadeOutViliger(1.0f);
        yield return new WaitForSeconds(1.0f);
        yield return StartCoroutine(FadeText(1.0f, false));
        foreach (var villiger in villigerSpots)
        {
            villiger.FadeOutViliger(1.0f);
        }
        yield return new WaitForSeconds(2.0f);
        NextYear();
        yield return new WaitForSeconds(1.0f);
        yield return StartCoroutine(FadeText(1.0f, true));
        allowInput = true;
    }

    public IEnumerator FadeText(float time, bool fadeIN)
    {
        yearText.CrossFadeAlpha(fadeIN ? 1 : 0, time, false);
        yield return new WaitForSeconds(time);
    }

    public void NextYear()
    {
        foreach (var spot in villigerSpots)
        {
            spot.Villiger = village.GetNextOffering();
            spot.SetSprite(PickVilligerSprite(spot.Villiger), 1.0f); 
        }
        village.UpdateVillage();
        yearText.text = village.YearText;
        populationText.text = village.Population.ToString();
    }

    public Sprite PickVilligerSprite(IVilliger villiger)
    {
        return VilligerSprites[Random.Range(0, VilligerSprites.Length)];
    }
}