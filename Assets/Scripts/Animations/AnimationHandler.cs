using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimationHandler {
	private GameObject arms = GameObject.Find ("arms");
	private GameObject baby = GameObject.Find ("baby");

	public void HandleAnimation(string animation) {
		arms.GetComponent<ArmAnimatorController> ().TriggerAnimation (animation);
		baby.GetComponent<BabyAnimatorController> ().TriggerAnimation (animation);
	}
}
