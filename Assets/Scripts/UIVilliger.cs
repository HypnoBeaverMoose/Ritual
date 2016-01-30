using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public interface IVilliger
{ };
public class UIVilliger : MonoBehaviour
{
    
    public delegate void ViligerSelected(UIVilliger villiger);
    public event ViligerSelected OnViligerSelected;
    public Image Sprite;
    public Text Message;


    public IVilliger Villiger { get; set; }
    public Sprite Image {get; set;}
    public ViligerTraits Trait { get; set; }
    public string Text {get; set;}

    void Start () 
    {
        Message.text = Text;
	}

    public void SelectVillager()
    {
        if (OnViligerSelected != null)
        {
            OnViligerSelected(this);
        }
    }
}
