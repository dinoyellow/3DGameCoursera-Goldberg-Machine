using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramp : MonoBehaviour {

	public Rigidbody rb;
	public float LauncherForce;

	public void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.CompareTag("fly"))
		{
			rb.velocity = Vector2.up * LauncherForce;
		}
	}
}