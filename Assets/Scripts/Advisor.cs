using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Advisor : MonoBehaviour {

    public string[] outputTexts;

    public Text output;
	
    // Use this for initialization
	void Start () 
    {
	
	}
	
    public void ShowVilligerAdvice(UIVilliger villiger)
    {
        StartCoroutine(ShowText(outputTexts[Random.Range(0, outputTexts.Length)]));
    }

    public IEnumerator ShowText(string text)
    {
        output.CrossFadeAlpha(0, 0.2f, false);
        yield return new WaitForSeconds(0.2f);
        output.text = text;
        output.CrossFadeAlpha(1, 0.2f, false);
        yield return new WaitForSeconds(0.2f);
    }
}
