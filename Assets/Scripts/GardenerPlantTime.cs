using UnityEngine;
using System.Collections;

public class GardenerPlantTime : MonoBehaviour {

	public GameObject plant;
	public float timeToPlant = 5.0F;
	private float timeElapsed = 0.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > timeToPlant) {
			timeToPlant = Time.time + 5;
			GameObject clone = Instantiate(plant, transform.position, transform.rotation) as GameObject;
		}
	}
}
//
//GardenerPlantTime.cs: Update:
//	
//	// planting based on time elapsed... lookup "Time.time" in Unity docs
//	
//	if ( "timeToPlant" - total time elapsed < 0 )
//		
//		instantiate a tree at my current position
//			
//			add 5 to "timeToPlant"