﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MakeChoice : MonoBehaviour {
	private GameObject baby;
	public bool IsAnswer;

	public void OnClick(dfControl control, dfMouseEventArgs mouseEvent) {
		baby = GameObject.FindGameObjectWithTag ("Baby");
		Debug.Log (this.transform.name);
		print (baby.name);
		baby.GetComponent<BabyAnimatorController>().currentState = transform.name;
		baby.GetComponent<BabyAnimatorController>().hasChanged = true;
		CaseInitializer.Instance.ActiveCase.isCorrect = IsAnswer;
	}
}
