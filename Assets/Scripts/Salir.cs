using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Salir : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if(!SceneManager.GetActiveScene().name.Equals("Ejercicio1")) SceneManager.LoadScene ("Ejercicio1");
			else Application.Quit ();
		}
	}
}
