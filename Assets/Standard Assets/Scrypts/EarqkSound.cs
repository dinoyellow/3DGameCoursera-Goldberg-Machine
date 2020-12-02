using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarqkSound : MonoBehaviour {

	public AudioSource EartqkSndSource;

	// Use this for initialization
	void Start () {

		EartqkSndSource = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Player") {

			EartqkSndSource.Play ();
		
		}
	}
}