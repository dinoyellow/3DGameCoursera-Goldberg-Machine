using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSnd: MonoBehaviour {

	public AudioSource FireSndSource;

	// Use this for initialization
	void Start () {

		FireSndSource = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{    
		if(other.tag == "Player") {

			FireSndSource.Play ();
		
		}
	}
}