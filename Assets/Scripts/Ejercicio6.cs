using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ejercicio6 : MonoBehaviour {

	public GUIStyle _buttonStyle;
	public GUIStyle _windowStyle;

	Rect _window = new Rect (200, 200, 200, 160);

	void OnGUI() {
		_window = ClampToScreen(GUI.Window(0, _window, Drag, "Menú", _windowStyle));
	}

	void Drag(int windowID) {
		GUI.DragWindow(new Rect(0, 0, 200, 40));
		if (GUI.Button (new Rect (20, 40, 160, 25), "Ejercicio 2", _buttonStyle)) SceneManager.LoadScene ("Ejercicio2");
		if (GUI.Button(new Rect(20, 80, 160, 25), "Ejercicio 3", _buttonStyle)) SceneManager.LoadScene ("Ejercicio3");
		if (GUI.Button(new Rect(20, 120, 160, 25), "Ejercicio 4", _buttonStyle)) SceneManager.LoadScene ("Ejercicio4");
	}

	Rect ClampToScreen(Rect r) {
		r.x = Mathf.Clamp(r.x, 0, Screen.width - r.width);
		r.y = Mathf.Clamp(r.y, 0, Screen.height - r.height);
		return r;
	}
}
