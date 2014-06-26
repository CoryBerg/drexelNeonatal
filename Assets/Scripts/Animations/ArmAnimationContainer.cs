using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArmAnimationContainer : MonoBehaviour {
	private List<string> animations;

	// Use this for initialization
	void Awake() {
		animations = new List<string> ()
			{
				"Idle",
				"NeedleDecomp",
				"UseStethoscope",
				"ChestCompression",
				"Sunction",
				"Intubation",
			};
	}

	public string GetAnimation(int index) {
		return animations [index];
	}
}
