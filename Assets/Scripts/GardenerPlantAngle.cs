using UnityEngine;
using System.Collections;

public class GardenerPlantAngle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
//	void Update () {
//	
//	}
//}

	public float yRotation = 5.0F;

	public float last_y_angle;
	public float current_y_angle;

	void Update() {

		yRotation += Input.GetAxis("Horizontal");
		transform.eulerAngles = new Vector3(10, yRotation, 0);
	}
	void Example() {
		print(transform.eulerAngles.x);
		print(transform.eulerAngles.y);
		print(transform.eulerAngles.z);
	}
}

// plant based on when I turn... lookup "transform.eulerAngles" in Unity docs

//if ( "last_y_angle" - current_y_angle > 15 degrees )
//	
//	instantiate a tree at my current position
//		
//		set "last_y_angle" equal to current_y_angle