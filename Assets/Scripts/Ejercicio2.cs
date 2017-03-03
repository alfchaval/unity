using UnityEngine;
using System.Collections;

public class Ejercicio2 : MonoBehaviour {

	Rect _rectTitulo = new Rect (Screen.width / 3, Screen.height / 10, Screen.width / 3, Screen.height / 10);
	Rect _rectLabel = new Rect (Screen.width / 3, Screen.height * 9 / 20, Screen.width / 3, Screen.height * 11 / 20);

	bool _mostrar = false;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			_mostrar = !_mostrar;
		}
	}
	void OnGUI(){
		GUI.color = Color.black;

		GUI.Label (_rectTitulo, "Pulsa espacio para mostrar/ocultar el mensaje");

		if (_mostrar)
		{
			GUI.Label(_rectLabel, "Soy el mensaje mostrado con GUI.Label");
		}
	}
}
