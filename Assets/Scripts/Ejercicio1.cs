using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ejercicio1 : MonoBehaviour {

	Rect _rect = new Rect (Screen.width / 3, Screen.height / 10, Screen.width / 3, Screen.height * 8 / 10);
	Color _colorFondo = new Color(0f,0.7f,0.7f,1f);
	Color _colorTexto = Color.yellow;
	int _nBotonCli = -1;

	string[] _listaBotones = {"Dos","Tres","Cuatro","Cinco","Seis","Siete","Ocho","Nueve","Diez"};

	void OnGUI () {
		GUI.backgroundColor = _colorFondo;
		GUI.contentColor = _colorTexto;
		_nBotonCli = GUI.SelectionGrid(_rect,_nBotonCli,_listaBotones,1);
		OpenScene (_nBotonCli);
	}

	void OpenScene(int scene) {
		if (scene != -1) SceneManager.LoadScene ("Ejercicio"+(scene+2));
	}
}
