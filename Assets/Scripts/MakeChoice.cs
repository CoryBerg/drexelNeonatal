using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MakeChoice : MonoBehaviour {
	public bool IsAnswer;

	private GameObject arms;

	void Awake() {
		arms = GameObject.Find ("arms");
	}

	public void OnClick(dfControl control, dfMouseEventArgs mouseEvent) {
		arms.GetComponent<ArmAnimatorController>().TriggerAnimation(transform.name);
		CaseInitializer.Instance.ActiveCase.isCorrect = IsAnswer;
	}
}
