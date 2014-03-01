using UnityEngine;
using System.Collections;

public class CorrectChoice : MonoBehaviour {

	public dfButton buttonState;


	// Update is called once per frame
	void Update () {
		if(buttonState.State == dfButton.ButtonState.Pressed) {
			Camera.main.GetComponent<RespiratoryCase>().isCorrect = true;
		}
	}
}
