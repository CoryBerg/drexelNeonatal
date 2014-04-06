using UnityEngine;
using System.Collections;

public class BabyAnimatorController : MonoBehaviour {

	public Animator animator;
	public string currentState;

	public GameObject baby;
	public Avatar a1;
	public GameObject needle;
	public Avatar a2;
	public GameObject lar;
	public Avatar a3;
	public GameObject syringe;
	public Avatar a4;



	public bool hasChanged = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		ActiveState();
	}

	// XML replacement, holds states and animations
	void ActiveState() {
		if(hasChanged) {
			switch(currentState) {
				case "ButtonSunctionbaby":
					baby.SetActive(true);
					needle.SetActive(false);
					lar.SetActive(false);
					syringe.SetActive(false);
					this.animator.avatar = a1;
					animator.SetBool("a", false);
					animator.SetBool("b", true);
					animator.SetBool("c", false);
					animator.SetBool("d", false);
					animator.SetBool("e", false);
					hasChanged = false;
					break;
				case "ButtonNeedle":
					baby.SetActive(false);
					needle.SetActive(true);
					lar.SetActive(false);
					syringe.SetActive(false);
					this.animator.avatar = a2;
					animator.SetBool("a", false);
					animator.SetBool("b", false);
					animator.SetBool("c", true);
					animator.SetBool("d", false);
					animator.SetBool("e", false);
					hasChanged = false;
					break;
				case "ButtonPulmonology":
					baby.SetActive(false);
					needle.SetActive(false);
					lar.SetActive(true);
					syringe.SetActive(false);
					this.animator.avatar = a3;
					animator.SetBool("a", false);
					animator.SetBool("b", false);
					animator.SetBool("c", false);
					animator.SetBool("d", true);
					animator.SetBool("e", false);
					break;
				case "ButtonSurgery":
					baby.SetActive(true);
					needle.SetActive(false);
					lar.SetActive(false);
					syringe.SetActive(true);
					this.animator.avatar = a4;
					animator.SetBool("a", false);
					animator.SetBool("b", false);
					animator.SetBool("c", false);
					animator.SetBool("d", false);
					animator.SetBool("e", true);
					hasChanged = false;

					break;
				default:
					baby.SetActive(true);
					needle.SetActive(false);
					lar.SetActive(false);
					syringe.SetActive(false);
					this.animator.avatar = a1;
					animator.SetBool("a", true);
					animator.SetBool("b", false);
					animator.SetBool("c", false);
					animator.SetBool("d", false);
					animator.SetBool("e", false);
					hasChanged = false;
					break;
			}
		}
	}

/*	void switch_behave()
	{
		character.active = !character.active; // Enable If Disabled & Disable If Enabled
		
		// Same Here >>> Enable If Disabled & Disable If Enabled
		GameObject.Find ("baby").GetComponent<other_script_1> ().enabled = !GameObject.Find ("baby").GetComponent<other_script_1> ().enabled; 
		GameObject.Find ("butterflyInsert").GetComponent<other_script_2> ().enabled = !GameObject.Find ("butterflyInsert").GetComponent<other_script_2> ().enabled;
		GameObject.Find ("largynoscope").GetComponent<other_script_3> ().enabled = !GameObject.Find ("largynoscope").GetComponent<other_script_3> ().enabled;
		GameObject.Find ("syringeInsert").GetComponent<other_script_4> ().enabled = !GameObject.Find ("syringeInsert").GetComponent<other_script_4> ().enabled;
		}*/
}
