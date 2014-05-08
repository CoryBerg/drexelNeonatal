using UnityEngine;
using System.Collections;

public class BabyAnimatorController : MonoBehaviour {
	public string currentState;
	public GameObject player;
	public bool hasChanged = false;

	private Animator animator;

	private string butt = "Butterfly";
	private string steth = "Stethoscope";
	private string chest = "ChestCompression";
	private string syri = "Syringe";
	private string lary = "Larygynoscope";
	private string bag = "BagAndMask";

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		ActiveState();
	}

	// XML replacement, holds states and animations
	void ActiveState() {
		if(hasChanged) {
			switch(currentState) {
				case "ButtonNeedle":
					animator.SetBool(butt, true);
					animator.SetBool(steth, false);
					animator.SetBool(chest, false);
					animator.SetBool(syri, false);
					animator.SetBool(lary, false);
					animator.SetBool(bag, false);
					hasChanged = false;
					player.GetComponent<RespiratoryCase>().isCorrect = true;
					break;

				case "ButtonSteth":
					animator.SetBool(butt, false);
					animator.SetBool(steth, true);
					animator.SetBool(chest, false);
					animator.SetBool(syri, false);
					animator.SetBool(lary, false);
					animator.SetBool(bag, false);
					hasChanged = false;
					break;

				case "ButtonChest":
					animator.SetBool(butt, false);
					animator.SetBool(steth, false);
					animator.SetBool(chest, true);
					animator.SetBool(syri, false);
					animator.SetBool(lary, false);
					animator.SetBool(bag, false);
					break;

				case "ButtonFluid":
					animator.SetBool(butt, false);
					animator.SetBool(steth, false);
					animator.SetBool(chest, false);
					animator.SetBool(syri, true);
					animator.SetBool(lary, false);
					animator.SetBool(bag, false);
					hasChanged = false;
					break;

				case "ButtonIntubation":
					animator.SetBool(butt, false);
					animator.SetBool(steth, false);
					animator.SetBool(chest, false);
					animator.SetBool(syri, false);
					animator.SetBool(lary, true);
					animator.SetBool(bag, false);
					hasChanged = false;
					break;

				case "ButtonSunctionbaby":
					animator.SetBool(butt, false);
					animator.SetBool(steth, false);
					animator.SetBool(chest, false);
					animator.SetBool(syri, false);
					animator.SetBool(lary, false);
					animator.SetBool(bag, true);
					hasChanged = false;
					break;

				default:
					animator.SetBool(butt, false);
					animator.SetBool(steth, false);
					animator.SetBool(chest, false);
					animator.SetBool(syri, false);
					animator.SetBool(lary, false);
					animator.SetBool(bag, false);
					hasChanged = false;
					break;
			}
		}
	}
}
