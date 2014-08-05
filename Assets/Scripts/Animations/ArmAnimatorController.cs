using UnityEngine;
using System.Collections;

public class ArmAnimatorController : MonoBehaviour {
	private Animator animator;
	private ArmAnimationContainer animations;
	private ArmItemsContainer items;
	private ArmSpecialCase special;
	private Transform startingParent;
	private Vector3 startingLocalPos;
	private bool doOnce = true;
	public static ArmAnimatorController Instance;
	// Use this for initialization
	void Awake() {
		Instance = this;
		animations = new ArmAnimationContainer ();
		items = new ArmItemsContainer ();
		special = new ArmSpecialCase ();

		animator = GetComponent<Animator> ();

		items.DisableAllItems ();
		startingParent = this.transform.parent;
		startingLocalPos = this.transform.localPosition;
	}

	// Called every frame
	void Update() {
		if (animator.GetCurrentAnimatorStateInfo (0).IsName ("Return") && doOnce) {
			doOnce = false;
		}
	}

	void ResetArms() {
		this.transform.parent = startingParent;
		this.transform.localPosition = startingLocalPos;
	}

	public void Stethescope(Transform target) {
		transform.parent = target;
		transform.localPosition = Vector3.zero;
		animator.SetTrigger("UseStethoscope");
	}

	// Triggers mechanim state for animation
	public void TriggerAnimation(string animation) {
		ResetArms();
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
