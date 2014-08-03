using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MakeChoice : MonoBehaviour {
	public bool IsAnswer;

	// Not a great solution, but should work....
	public bool StethescopeOverride = false;
	public Transform StethescopeTarget;

	private AnimationHandler handler;

	void Awake() {
		handler = AnimationHandler.Instance;
	}

	public void OnClick(dfControl control, dfMouseEventArgs mouseEvent) {
		if(StethescopeOverride && StethescopeTarget != null) {
			handler.HandleStethescopeAnimation(StethescopeTarget);
			return;
		}
		handler.HandleAnimation (transform.name);
		CaseInitializer.Instance.ActiveCase.isCorrect = IsAnswer;
	}
}
