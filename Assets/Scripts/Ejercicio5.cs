using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ejercicio5 : MonoBehaviour {

	Rect _rect = new Rect (Screen.width * 2 / 6, Screen.height / 10, Screen.width / 3, Screen.height / 10);
	Color _colorFondo = new Color(0f,0.7f,0.7f,1f);
	Color _colorTexto = Color.yellow;
	int _nBotonCli = -1;

	string[] _listaBotones = {"Salir", "Continuar"};

	public GameObject _cubo;

	bool _pausa = false;

	void Update () {
		if (!_pausa) _cubo.transform.Rotate (100 * Time.deltaTime, 100 * Time.deltaTime, 100 * Time.deltaTime);
		if(Input.GetKeyDown(KeyCode.Escape)) _pausa = true;
	}

	void OnGUI () {
		if (_pausa) {
			GUI.backgroundColor = _colorFondo;
			GUI.contentColor = _colorTexto;
			_nBotonCli = GUI.SelectionGrid(_rect,_nBotonCli,_listaBotones,2);
			Salir (_nBotonCli);
		}

	}
		
	public void Salir(int respuesta)
	{
		if(respuesta == 0) SceneManager.LoadScene ("Ejercicio1");
		if (respuesta == 1) {
			_pausa = false;
			_nBotonCli = -1;
		}
	}
}