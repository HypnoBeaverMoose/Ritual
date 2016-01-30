using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NewVilliger {

	public int Age { get; set; }
	public bool IsMale { get; set; }
	public bool IsHealthy { get; set; }
	public bool IsWealthy { get; set; }
	public bool IsFertile { get; set; }

	public NewVilliger (int age, bool isMale, bool isHealthy) {
		Age = age;
		IsMale = isMale;
		IsHealthy = isHealthy;
	}

	public override string ToString ()
	{
		return string.Format ("[NewVilliger: Age={0}, IsMale={1}, IsHealthy={2}, IsWealthy{3}]", Age, IsMale, IsHealthy, IsWealthy);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
