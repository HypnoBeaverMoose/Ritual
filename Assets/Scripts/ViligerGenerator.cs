using UnityEngine;
using System.Collections;
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
        if(FindObjectOfType<ViligerGenerator>() !=null)
        {
            Destroy(gameObject);
            return;
        }
	    Instance = this;
        DontDestroyOnLoad(this);
	}

    public Viliger CreateRandomViliger()
    {        
        var go = Instantiate(ViligerPrefab);
        var viliger = go.GetComponent<Viliger>();
        int traitIndex = Random.Range(0, Viligers.Length);
        viliger.Image = Viligers[traitIndex].Image;       
        viliger.Trait = Viligers[traitIndex].Trait;
        viliger.Text = Viligers[traitIndex].Text;

        return viliger;
    }
	

}
