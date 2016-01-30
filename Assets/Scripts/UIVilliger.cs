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

    private Sprite sprite;
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
    public void SetSprite(Sprite sprite)
    {
        VilligerGameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
