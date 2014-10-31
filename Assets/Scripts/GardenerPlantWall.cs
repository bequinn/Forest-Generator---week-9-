using UnityEngine;
using System.Collections;

public class GardenerPlantWall : MonoBehaviour {

	public GameObject leftObject; //object planted if wall on left
	public GameObject rightObject; // object planted if wall on right

	public float timeToPlant = 5.0F;
	private float timeElapsed = 0.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray rayRight = new Ray(transform.position, transform.right);
		Ray rayLeft = new Ray(transform.position, -transform.right);

		RaycastHit rayHit = new RaycastHit ();  //initialize forensics data container

		Vector3 right = transform.TransformDirection (Vector3.right);

		Vector3 left = transform.TransformDirection (Vector3.left);


		if (Physics.Raycast (transform.position, right, 1) && Time.time > timeToPlant) {
			timeToPlant = Time.time + 5;
			GameObject clone = Instantiate(rightObject, transform.position, transform.rotation) as GameObject;
			print ("There is something on the right of the object");		
		}

		if (Physics.Raycast (transform.position, left, 1) && Time.time > timeToPlant) {
			timeToPlant = Time.time + 5;
			GameObject clone = Instantiate(leftObject, transform.position, transform.rotation) as GameObject;
			print ("There is something on the left of the object");		
		}
	
	}
}

