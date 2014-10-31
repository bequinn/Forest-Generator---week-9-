using UnityEngine;
using System.Collections;

public class GardenerMove : MonoBehaviour {

	//public Transform gardener;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit rayHit = new RaycastHit(); //initialize forensics data container

		Vector3 forward = transform.TransformDirection (Vector3.forward);

		rigidbody.AddForce(forward);

//		if (Physics.Raycast (ray, out rayHit, 10f)){
//			transform.rotation = Random.rotation;
//
//		}

		if (Physics.Raycast (transform.position, forward, 1)) {
			print ("There is something in front of the object");		
		}
	}

	void OnCollisionEnter (Collision col){

		int right = 90;
		int left = -90;

		float randomNumber = Random.Range (0, 8);

		if (randomNumber >= 5) {

						transform.Rotate (0, right, 0);
						//rigidbody.AddForce(Vector3.forward);
				} 
		if (randomNumber < 5) {
			transform.Rotate (0, left, 0);
				}

	}
}

//Ray ray = new Ray(transform.position, transform.forward); forward tells which way an object is facing
