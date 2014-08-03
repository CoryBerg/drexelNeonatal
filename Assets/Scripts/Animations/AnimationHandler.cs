using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimationHandler {
	private ArmAnimatorController arms = GameObject.FindGameObjectWithTag ("Arms").GetComponent<ArmAnimatorController>();
	private BabyAnimatorController baby = GameObject.FindGameObjectWithTag ("Baby").GetComponent<BabyAnimatorController>();
	private static AnimationHandler inst;
	public static AnimationHandler Instance {
		get { 
			if(inst == null) {
				inst = new AnimationHandler();
			}
			return inst;
		}
	}

	public void HandleStethescopeAnimation(Transform target) {
		ArmAnimatorController.Instance.Stethescope(target);
	}

	public AnimationHandler() {
		Debug.Log("Making anim. handler");
		arms = ArmAnimatorController.Instance;
		baby = BabyAnimatorController.Instance;
	}

	public void HandleAnimation(string animation) {
		// if there the animation doesn't exist... don't play anything so the simulation doesn't break.
		if(animation == "") {
			return;
		}
		arms.TriggerAnimation (animation);
		baby.TriggerAnimation (animation);
	}
}
