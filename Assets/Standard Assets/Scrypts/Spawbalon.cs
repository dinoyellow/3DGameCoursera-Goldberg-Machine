﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawbalon : MonoBehaviour {

	// prefabs to instantiate
	public GameObject prefab1, prefab2, prefab3, prefab4; 

	// spawn prefabs once per 2 seconds
	public float spawnRate = 2f;
	
	// variable to set next spawn time
	float nextSpawn = 0f;

	// variable to contain randon value
	int whatToSpawn;

	// update is called once per framee
	void Update () {
		if (Time.time > nextSpawn) { // if time has come
			whatToSpawn = Random.Range (1,6); // define random value between 1 and 5 (6 is exclusive)
			Debug.Log (whatToSpawn); // display its value in console

			// instantiate a prefab depending an random value
			switch (whatToSpawn) {
			case 1:
				Instantiate (prefab1, transform.position, Quaternion.identity);
				break;
			case 2:
				Instantiate (prefab2, transform.position, Quaternion.identity);
				break;
			case 3:
				Instantiate (prefab3, transform.position, Quaternion.identity);
				break;
			case 4:
				Instantiate (prefab4, transform.position, Quaternion.identity);
				break;
			}

			// set next spawn time
			nextSpawn = Time.time + spawnRate;
		}
	}
}
		
	

