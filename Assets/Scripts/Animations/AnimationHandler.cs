using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimationHandler {
	private ArmAnimatorController arms = GameObject.FindGameObjectWithTag ("Arms").GetComponent<ArmAnimatorController>();
	private BabyAnimatorController baby = GameObject.FindGameObjectWithTag ("Baby").GetComponent<BabyAnimatorController>();

	public void HandleAnimation(string animation) {
		// if there the animation doesn't exist... don't play anything so the simulation doesn't break.
		if(animation == "") {
			return;
		}
		arms.TriggerAnimation (animation);
		baby.TriggerAnimation (animation);
	}
}
