using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewVilligeGenerator : MonoBehaviour {

	[SerializeField]
	private int initialPopulation;

	[SerializeField]
	private float ofThemBabies;
	[SerializeField]
	private float ofThemYoung;
	[SerializeField]
	private float ofThemMale;
	[SerializeField]
	private float ofThemHealthý;

	[SerializeField]
	private float youngAt;
	public float YoungAge { get { return youngAt; } }
	[SerializeField]
	private float oldAt;
	public float OldAge { get { return oldAt; } }

	//[HideInInspector]
	public List<NewVilliger> population { get; set; }

	private int randomAge;
	private bool randomIsMale;
	private bool randomIsHealthy;
	private bool randomIsFertile;

	void GenerateVillige () {
		population = new List<NewVilliger> ();
		int ageCopyofPop = initialPopulation;
		int genderCopyofPop = initialPopulation;
		int healthCopyofPop = initialPopulation;
		for (int i = 0; i < initialPopulation - 1; i++) {
			//Letś give it an age
			switch (Choose (new float[] { (ofThemBabies / ageCopyofPop), (ofThemYoung / ageCopyofPop), (ageCopyofPop - ofThemBabies - ofThemYoung) / ageCopyofPop})) {
			case 0:
				Debug.Log ("babies");
				randomAge = (int) Mathf.Lerp (0f, youngAt, Random.value);
				ofThemBabies -= 1;
				ageCopyofPop -= 1;
				break;
			case 1:
				Debug.Log ("young");
				randomAge = (int) Mathf.Lerp (youngAt, oldAt, Random.value);
				ofThemYoung -= 1;
				ageCopyofPop -= 1;
				break;
			case 2:
				Debug.Log ("old");
				randomAge = (int) Mathf.Lerp (oldAt, oldAt + 20f, Random.value);
				ageCopyofPop -= 1;
				break;
			}
			//Letś give it a gender
			switch (Choose (new float[] { (ofThemMale / genderCopyofPop), (genderCopyofPop - ofThemMale) / genderCopyofPop})) {
			case 0:
				Debug.Log ("male");
				randomIsMale = true;
				ofThemMale -= 1;
				genderCopyofPop -= 1;
				break;
			case 1:
				Debug.Log ("female");
				randomIsMale = false;
				genderCopyofPop -= 1;
				break;
			}
			//Letś give it a health
			switch (Choose (new float[] { (ofThemHealthý / healthCopyofPop), (healthCopyofPop - ofThemHealthý) / healthCopyofPop})) {
			case 0:
				Debug.Log ("healthy");
				randomIsHealthy = true;
				ofThemHealthý -= 1;
				healthCopyofPop -= 1;
				break;
			case 1:
				Debug.Log ("sick");
				randomIsHealthy = false;
				healthCopyofPop -= 1;
				break;
			}
			population.Add(new NewVilliger (randomAge, randomIsMale, randomIsHealthy));
			Debug.Log (population [i].ToString ());
		}
	}

	int Choose (float[] probs) {

		float total = 0;

		foreach (float elem in probs) {
			total += elem;
		}

		float randomPoint = Random.value * total;

		for (int i= 0; i < probs.Length; i++) {
			if (randomPoint < probs[i]) {
				return i;
			}
			else {
				randomPoint -= probs[i];
			}
		}
		return probs.Length - 1;
	}

	// Use this for initialization
	void Start () {
		GenerateVillige ();
	}

	// Update is called once per frame
	void Update () {
	}
}
