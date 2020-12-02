using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DcCSnd: MonoBehaviour {

	public AudioSource DcCSndSource;

	// Use this for initialization
	void Start () {

		DcCSndSource = GetComponent<AudioSource> ();

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{    
	     if(other.tag == "Cañon") {


			DcCSndSource.Play ();

		}
	}
}