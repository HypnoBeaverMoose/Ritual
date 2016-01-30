using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class UIVilliger : MonoBehaviour
{
    public delegate void ViligerHovered(UIVilliger villiger);
    public event ViligerHovered OnViligerHovered;
    
    public delegate void ViligerSelected(UIVilliger villiger);
    public event ViligerSelected OnViligerSelected;

    public GameObject VilligerGameObject;
    public IVilliger Villiger { get; set; }
    public Sprite Image {get; set;}
    public ViligerTraits Trait { get; set; }
    public string Text {get; set;}
    
    void Start () 
    {
        
	}

    public void SelectVillager()
    {
        if (OnViligerSelected != null)
        {
            OnViligerSelected(this);
        }
    }
    public void HoverVilliger()
    {
        if (OnViligerHovered != null)
        {
            OnViligerHovered(this);
        }
    }

    public void FadeOutViliger(float time)
    {
       StartCoroutine(FadeCoroutine(time, false));
    }

    public void SetSprite(Sprite sprite, float fadeTime)
    {
        var renderer = VilligerGameObject.GetComponent<SpriteRenderer>();
        renderer.sprite = sprite;
        var color = renderer.color;
        color.a = 0.0f;
        renderer.color = color;
        StartCoroutine(FadeCoroutine(fadeTime, true));
    }

    private IEnumerator FadeCoroutine(float time, bool fadeIn)
    {
        var renderer = VilligerGameObject.GetComponent<SpriteRenderer>();
        float timer = time;
        var dest = new Color(renderer.color.r, renderer.color.g, renderer.color.b, fadeIn ? 1 : 0);
        var color = renderer.color;
        while (timer > 0)
        {
            timer -= Time.deltaTime;
            renderer.color = Color.Lerp(dest, color, timer / time);
            yield return null;
        }
    }
}
