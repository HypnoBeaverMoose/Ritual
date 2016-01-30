using UnityEngine;
using System.Collections;
using System.Linq;
using System;
using Random = UnityEngine.Random;

public class ViligerGenerator : MonoBehaviour {

    [Serializable]    
    public struct ViligerByTrait
    {
        public string Text;
        public ViligerTraits Trait;
        public Sprite Image;
    }
    
    public ViligerByTrait[] Viligers;


    public GameObject ViligerPrefab;

    public static ViligerGenerator Instance{get; private set;}

	void Awake() 
    {
	    Instance = this;
        DontDestroyOnLoad(this);
	}

    //public UIVilliger CreateRandomViliger()
    //{        
    //    var go = Instantiate(ViligerPrefab);
    //    var viliger = go.GetComponent<UIViliger>();
    //    int traitIndex = Random.Range(0, Viligers.Length);
    //    viliger.Image = Viligers[traitIndex].Image;       
    //    viliger.Trait = Viligers[traitIndex].Trait;
    //    viliger.Text = Viligers[traitIndex].Text;

    //    return viliger;
    //}

    //public UIVilliger CreateViliger(ViligerTraits trait)
    //{
    //    var go = Instantiate(ViligerPrefab);
    //    var viliger = go.GetComponent<UIVilliger>();
    //    int traitIndex = Viligers.ToList().FindIndex(vil => vil.Trait == trait);
    //    viliger.Image = Viligers[traitIndex].Image;
    //    viliger.Trait = Viligers[traitIndex].Trait;
    //    viliger.Text = Viligers[traitIndex].Text;

    //    return viliger;
    //}	

}
