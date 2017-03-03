using UnityEngine;
using System.Collections;

public class MoverPersonaje : MonoBehaviour {

	Rigidbody _rb;

	private float _puntos = 50;
	private Rect _rect = new Rect (10,10,100,50);
	private GameObject _lastObject;

	private int _nObjetos;	

	void Start () {
		_rb = GetComponent<Rigidbody> ();
		_nObjetos = GameObject.FindGameObjectsWithTag ("Puntos_2").Length +
			GameObject.FindGameObjectsWithTag ("Puntos_3").Length +
			GameObject.FindGameObjectsWithTag ("Puntos_4").Length +
			GameObject.FindGameObjectsWithTag ("Puntos_5").Length;
	}

	void OnCollisionEnter(Collision collision) {
		int puntosASumar = 0;
		switch (collision.collider.tag) {
		case "Puntos_2":
			puntosASumar = 2;
			break;
		case "Puntos_3":
			puntosASumar = 3;
			break;
		case "Puntos_4":
			puntosASumar = 4;
			break;
		case "Puntos_5":
			puntosASumar = 5;
			break;
		default:
			return;
		}
		if (_lastObject != null) {
			bool eraCubo = (_lastObject.tag == "Puntos_3" || _lastObject.tag == "Puntos_5");
			bool esCubo = (collision.collider.tag == "Puntos_3" || collision.collider.tag == "Puntos_5");
			if (esCubo == eraCubo) {
				_puntos -= puntosASumar;
				_lastObject = collision.gameObject;
			} else {
				Destroy (collision.gameObject);
				Destroy (_lastObject);
				_puntos += puntosASumar;
				_lastObject = null;
				_nObjetos -= 2;
			}
		} else {
			_lastObject = collision.gameObject;
		}


	}

	void OnGUI(){
		if (_puntos > 0) {
			if(_nObjetos == 0) GUI.Label (_rect, "Has ganado");
			else GUI.Label (_rect, "Puntos: " + _puntos);
		}
		else GUI.Label (_rect, "Has perdido");

	}

	void Update () {
		float horizontal = Input.GetAxis("Horizontal"); 
		float vertical = Input.GetAxis("Vertical");
		_rb.transform.Translate(new Vector3(horizontal, 0, vertical) * Time.deltaTime * Time.timeScale, Space.World);

		if (_rb.transform.position.z > 2.4)
			_rb.transform.position = new Vector3(_rb.transform.position.x, _rb.transform.position.y, 2.4f);
		if (_rb.transform.position.z < -2.4)
			_rb.transform.position = new Vector3(_rb.transform.position.x, _rb.transform.position.y, -2.4f);
		if (_rb.transform.position.x > 2.4)
			_rb.transform.position = new Vector3(2.4f, _rb.transform.position.y, _rb.transform.position.z);
		if (_rb.transform.position.x < -2.4)
			_rb.transform.position = new Vector3(-2.4f, _rb.transform.position.y, _rb.transform.position.z);
	}
}
