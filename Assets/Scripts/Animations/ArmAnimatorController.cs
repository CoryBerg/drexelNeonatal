using UnityEngine;
using System.Collections;

public class ArmAnimatorController : MonoBehaviour {
	private Animator animator;
	private ArmAnimationContainer container;

	void Awake() {
		container = new ArmAnimationContainer ();
		animator = GetComponent<Animator> ();
	}

	// XML replacement, holds states and animations
	public void TriggerAnimation(string animation) {
		Debug.Log (animation);
		animator.SetTrigger (container.GetAnimation(animation));
	}
}
