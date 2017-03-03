using UnityEngine;
using System.Collections;

public class Ejercicio10 : MonoBehaviour {

	public GameObject _cubo;

	void Update () {
		_cubo.transform.Rotate (1, 1, 1);
		if (Input.GetKeyDown (KeyCode.Space)) Time.timeScale = 0;
		if (Input.GetKeyDown (KeyCode.A)) Time.timeScale = 1;
	}

	void FixedUpdate() {
		float horizontal = Input.GetAxis("Horizontal"); 
		float vertical = Input.GetAxis("Vertical");

		_cubo.transform.Translate(new Vector3(horizontal, vertical, 0) * Time.fixedDeltaTime * Time.timeScale, Space.World);

		if (_cubo.transform.position.y > 2.75)
			_cubo.transform.position = new Vector3(_cubo.transform.position.x, 2.75f, _cubo.transform.position.z);
		if (_cubo.transform.position.y < -0.75)
			_cubo.transform.position = new Vector3(_cubo.transform.position.x, -0.75f, _cubo.transform.position.z);
		if (_cubo.transform.position.x > 3.25)
			_cubo.transform.position = new Vector3(3.25f, _cubo.transform.position.y, _cubo.transform.position.z);
		if (_cubo.transform.position.x < -3.25)
			_cubo.transform.position = new Vector3(-3.25f, _cubo.transform.position.y, _cubo.transform.position.z);
	}

	void OnGUI() {
		GUI.Label (new Rect (10, 10, 100, 30), "TimeScale: " + Time.timeScale);
	}
}
