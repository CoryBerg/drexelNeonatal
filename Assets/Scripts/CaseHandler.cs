﻿using UnityEngine;
using System.Collections;

public enum NeonatalCase {
	Cardiac,
	Respiratory
}

public class CaseHandler : MonoBehaviour {
	public static CaseHandler Instance;
	public NeonatalCase currentCase;

	// Use this for initialization
	void Awake () {
		if(Instance != null) {
			Destroy(this.gameObject);
			return;
		}
		DontDestroyOnLoad(this.gameObject);
		Instance = this;
	}

	public void ActivateCase(NeonatalCase aCase) {
		currentCase = aCase;
	}

	public void ActivateCardiac() {
		ActivateCase(NeonatalCase.Cardiac);
	}

	public void ActivateRespiratory() {
		ActivateCase(NeonatalCase.Respiratory);
	}
}
