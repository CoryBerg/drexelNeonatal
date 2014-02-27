using UnityEngine;
using System.Collections;

public class BabyAnimatorController : MonoBehaviour {

	public Animator animator;
	public int currentState;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		ActiveState();
	}

	// XML replacement, holds states and animations
	void ActiveState() {
		if(currentState == 0) {
			animator.SetBool("isStruggling", false);
			animator.SetBool("tPose", true);
		}
		else if(currentState == 1) {
			animator.SetBool("tPose", false);
			animator.SetBool("isStruggling", true);
		}
	}
}
