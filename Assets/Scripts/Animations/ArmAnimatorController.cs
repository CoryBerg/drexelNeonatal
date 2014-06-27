using UnityEngine;
using System.Collections;

public class ArmAnimatorController : MonoBehaviour {
	private Animator animator;
	private ArmAnimationContainer animations;
	private ArmItemsContainer items;

	// Use this for initialization
	void Awake() {
		animations = new ArmAnimationContainer ();
		items = new ArmItemsContainer ();
		animator = GetComponent<Animator> ();

		items.DisableAllItems ();
	}

	// Triggers mechanim state for animation
	public void TriggerAnimation(string animation) {
		items.EnableItem (animation);
		animator.SetTrigger (animations.GetAnimation(animation));
	}
}
