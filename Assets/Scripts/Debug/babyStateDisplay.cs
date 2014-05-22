using UnityEngine;
using System.Collections;


public class babyStateDisplay : MonoBehaviour {

	public GameObject respiratoryCase;
	int state;

	// diaplay the state of baby with gui lable
	void Update(){
		state = respiratoryCase.GetComponent<RespiratoryCase>().currentState;

		switch(state)
		{	
			case 0:
				this.GetComponent<dfLabel>().Text = "Current baby state is: Initial";
				break;

			case 1:
				this.GetComponent<dfLabel>().Text = "Current baby state is: No action in 5 minutes or incorrect actions";
				break;

			case 2:
				this.GetComponent<dfLabel>().Text = "Current baby state is: Correct needle decomp, baby healthy";
				break;

			case 3:
				this.GetComponent<dfLabel>().Text = "Current baby state is: No action in 10 minutes, or incorrect actions x2";
				break;
		}
			
	}
}
