using UnityEngine;
using System.Collections;

public class ArmAnimatorHandle : MonoBehaviour {
	public Animator animator;

	// Use this for initialization
	void Awake () {
		animator = GetComponent<Animator> ();
	}

	// Triggers animation by animation name
	private void TriggerAnimation(string animation) {
		animator.SetTrigger (animation);
	}
}
