using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Viliger : MonoBehaviour {

    public delegate void ViligerSelected(ViligerTraits trait);
    public event ViligerSelected OnViligerSelected;
    public Image Icon;
    public Text Message;

    public Sprite Image {get; set;}
    public ViligerTraits Trait { get; set; }
    public string Text {get; set;}

    void Start () 
    {
        Message.text = Text;
        Icon.sprite = Image;
	}

    public void SelectVillager()
    {
        if (OnViligerSelected != null)
        {
            OnViligerSelected(Trait);
        }
    }
}
