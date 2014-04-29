using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TextPopup : MonoBehaviour {

	private GameObject popup;
	private string action;

	public void OnClick(dfControl control, dfMouseEventArgs mouseEvent) {
		Debug.Log (this.transform.name);

		action = "Current Operation: " + this.GetComponent<dfButton>().Text;
		StartCoroutine(ShowMessage(action, 3));



	}

	IEnumerator ShowMessage (string message, float delay) {

		popup = GameObject.Find ("PopupMessage");

		popup.GetComponent<dfLabel>().Text = message;
		popup.GetComponent<dfLabel>().IsVisible = true;
		yield return new WaitForSeconds(delay);
		popup.GetComponent<dfLabel>().IsVisible = false;
	}
}
