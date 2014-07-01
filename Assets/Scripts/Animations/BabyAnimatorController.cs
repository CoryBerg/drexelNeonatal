using UnityEngine;
using System.Collections;

public class BabyAnimatorController : MonoBehaviour {
	private Animator animator;
	private BabyAnimationContainer animations;

	// Use this for initialization
	void Awake() {
		animations = new BabyAnimationContainer ();
		animator = GetComponent<Animator> ();
	}

	// Triggers mechanim state for animation
	public void TriggerAnimation(string animation) {
		animator.SetFloat ("State", animations.GetAnimation(animation));
	}
}
