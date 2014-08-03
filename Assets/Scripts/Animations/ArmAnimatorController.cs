using UnityEngine;
using System.Collections;

public class ArmAnimatorController : MonoBehaviour {
	private Animator animator;
	private ArmAnimationContainer animations;
	private ArmItemsContainer items;
	private ArmSpecialCase special;

	private bool doOnce = true;
	public static ArmAnimatorController Instance;
	// Use this for initialization
	void Awake() {
		print("Hello arm anim");
		Instance = this;
		animations = new ArmAnimationContainer ();
		items = new ArmItemsContainer ();
		special = new ArmSpecialCase ();

		animator = GetComponent<Animator> ();

		items.DisableAllItems ();
	}

	// Called every frame
	void Update() {
		if (animator.GetCurrentAnimatorStateInfo (0).IsName ("Return") && doOnce) {
			doOnce = false;
		}
	}

	public void Stethescope(Transform target) {
		print ("Steth");
		transform.parent = target;
		transform.localPosition = Vector3.zero;
		animator.SetTrigger("UseStethoscope");
	}

	// Triggers mechanim state for animation
	public void TriggerAnimation(string animation) {
		print (animation);
		items.NewAnimation (animation);

		if(animation == "ButtonIntubation") {
			doOnce = true;
			special.EnableSpecialCaseItem (items);
		}
		string animName = animations.GetAnimation(animation);
		if(animName == "") {
			print ("Animation DNE");
			return;
		}

		animator.SetTrigger (animName);
	}
}
