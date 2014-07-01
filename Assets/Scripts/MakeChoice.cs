using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MakeChoice : MonoBehaviour {
	public bool IsAnswer;

	private AnimationHandler handler;

	void Awake() {
		handler = new AnimationHandler ();
	}

	public void OnClick(dfControl control, dfMouseEventArgs mouseEvent) {
		handler.HandleAnimation (transform.name);
		CaseInitializer.Instance.ActiveCase.isCorrect = IsAnswer;
	}
}
