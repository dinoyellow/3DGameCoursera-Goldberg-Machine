using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateModifierScript : MonoBehaviour {

	// Rotate speed variable can be set in Inspector with slider and range from 1 to 30
	[Range(1f, 30f)]
	public float rotateSpeed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Get Input from Z key on keyboard
		if (Input.GetKey (KeyCode.Z))

			// Increase rotation angle in Z axis value according to rotateSpeed
			transform.Rotate (0, 0, Time.deltaTime * rotateSpeed, Space.Self);

		// Get Input from X key on keyboard
		if (Input.GetKey(KeyCode.X))

			// Decrease rotation angle in Z axis value according to rotateSpeed
			transform.Rotate (0, 0, - Time.deltaTime * rotateSpeed, Space.Self);
	}
}
