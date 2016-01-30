using UnityEngine;
using System.Collections;

public class NewVillige : MonoBehaviour {

	public int Year { get; private set; }

	public int Population { get; private set; }

	public string YearText { get; private set; }

	#region lifeParams
	public float birthRate = 0.2f;
	public float mortalityRate = 0.1f;
	public float sicknessSpreadRate = 0.5f;
	#endregion

	#region refs
	NewVilligeGenerator gen;
	#endregion

	void Sacrifice(NewVilliger villiger) {
		//We remove the chosen one from the population
		gen.population.Remove (villiger);
		//We apply the effects of the sacrifice
		if (villiger.IsMale) {
			if (villiger.Age < 35) {
				//A young male -> fertility rises
			} else {
				//An old male -> Chance for female offspring rises
			}
			if (villiger.IsWealthy) {
				//A wealthy male -> Health rises
			}
		} else {
			if (villiger.Age < 35) {
				//A young female -> More rain
			} else {
				//An old female -> More drought
			}
			if (villiger.IsWealthy) {
				//A wealthy female -> Chance for male offspring rises
			}
		}
	}

	NewVilliger GetNextOffering();

	void UpdateVillage() {
		foreach (NewVilliger villiger in gen.population) {
			villiger.Age += 1;
			if (villiger.Age > 35 && 
		}
	}

	

	// Use this for initialization
	void Start () {
		Year = 0;
		Population = gen.population.Count;
		YearText = "Drought has killed most of the crops. 15 people died from starvation.";

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
