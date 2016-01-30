using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Viliger : MonoBehaviour {

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
	
	void Update () {
	
	}
}
