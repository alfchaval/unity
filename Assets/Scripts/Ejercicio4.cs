using UnityEngine;
using System.Collections;

public class Ejercicio4 : MonoBehaviour {

	MeshRenderer _render;
	Transform _transform;
	Color _colorOriginal = Color.white;

	void Start () {
		_render = GetComponent<MeshRenderer>();
		_transform = GetComponent<Transform>();
	}

	void Update () {
		_transform.Rotate (100*Time.deltaTime, 100*Time.deltaTime, 100*Time.deltaTime);
	}

	void OnMouseEnter()
	{
		_colorOriginal = _render.material.color;
		_render.material.color = new Color(Random.Range(0F, 1F), Random.Range(0F, 1F), Random.Range(0F, 1F));

			
	}

	void OnMouseExit()
	{
		_render.material.color = _colorOriginal;
	}

	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(0))
		{
			_colorOriginal = _render.material.color;
		}
	}
}
