using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MakeChoice : MonoBehaviour {
	public GameObject baby;
	public GameObject player;

	public void OnClick(dfControl control, dfMouseEventArgs mouseEvent) {
		Debug.Log (this.transform.name);

		baby.GetComponent<BabyAnimatorController>().currentState = transform.name;
		baby.GetComponent<BabyAnimatorController>().hasChanged = true;

		//player.GetComponent<RespiratoryCase> ().isCorrect = true;
	}
}
