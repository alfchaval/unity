using UnityEngine;
using System.Collections;

public class Ejercicio7 : MonoBehaviour {

	private float margenX = 30;
	private float margenY = 30;

	float[] valores = new float[] {65, 50, 60, 70, 65, 80, 40, 75, 65, 45};

	void OnGUI() {
		GUI.Box(new Rect(
			(Screen.width - ((valores.Length + 1) * margenX + Screen.width / 40)) / 2,
			Screen.height / 4,
			(Screen.width - ((valores.Length + 1) * margenX + Screen.width / 40)) / 2,
			Screen.height / 2),
			"Ecualizador");

		for (int i = 0; i < valores.Length; i++) {
			valores[i] = GUI.VerticalSlider(
				new Rect(
					(Screen.width - ((valores.Length + 1) * margenX + Screen.width / 40)) / 2 + margenX * ( i + 1),
					Screen.height / 4 + margenY,
					Screen.width / 40,
					Screen.height / 2 - 2 * margenY
				),
				valores[i], 100, 0);
		}
	}
}

