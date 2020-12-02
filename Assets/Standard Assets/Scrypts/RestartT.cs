using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartT : MonoBehaviour {

	public void RestartGame()
	{
		SceneManager.LoadScene("Terrain GM 2");
	}
}
