using UnityEngine;
using System.Collections;

public class RespiratoryCase : MonoBehaviour {
	public Animator baby;
	public bool isCorrect = false;
	public float timer = 0.0f;

	int currentState = 0;
	/*
	*	States:
	*		0 - Initial
	*		1 - No action 5 minutes or improper needle decomp
	*		2 - Correct needle decomp, baby healthy
	*		3 - No action 10 minutes, or improper needle decomp x2
	*/
	
	// Update is called once per frame
	void Update () {
		if(!isCorrect) {
			timer += Time.deltaTime;

			if((timer >= 300.0f) && (currentState == 0)) {
				FurtherDecomp();
			}
			else if((timer >= 600.0f) && (currentState == 1)) {
				BabyDeath();
			}
			else {
				InitialState();
			}
		}
		else {
			BabyRecovery();
		}
	}

	// Initial state of baby
	void InitialState() {
		// Chest retractions
		// Nasal flaring
		// Grunting

		// No breathing sounds
		// Blue color around lips
		// Left chest does not move

		// PIP 30, PEEP, Rate 45
		// FIO2 100%

		// SpO2 75%
		// Temperature 37.1 C
		// Respiratory Rate 90 breathes/min
		// Blood pressure 50/25 mmHg
		// Pulse strength weak
	}

	// No needle decomp by 5 min (regardless of interations or lack thereof) or needle decomp in incorrect location
	void FurtherDecomp() {
		currentState = 1;

		// Chest retraction
		// Nasal flaring
		// Grunting

		// SpO2 60%
		// Cyanosis enabled
		// Respiratory rate 120 breathes/min
		// Blood pressure 30/10 mmHg
		// Heart rate 220bpm
		// Pulse strength weak
	}

	// Needle decomp by 5 min in correct location
	void BabyRecovery() {
		currentState = 2;

		// No retrations
		// No nasal flaring
		// No grunting

		// SpO2 94%
		// Cyanosis disabled
		// Respiratory rate 40 breathes/min
		// Blood pressure 65/35 mmHg
		// Heart rate140 bpm
		// Pulse strength strong

		// END SCENARIO WITH WIN

		//baby.GetComponent<BabyAnimatorController>().currentState = "";

		Invoke ("ChangeScene", 3.0f);
	}

	// No needle decomp by 10 min (5+5, regardless of interations or lack thereof) or needle decomp in incorrect location
	void BabyDeath() {
		currentState = 3;

		// Lethargic
		// No chest retrations
		// No nasal flaring
		// No grunting

		// SpO2 30%
		// Cyanosis enabled
		// Respiratory rate 60 breathes/min
		// Blood pressure 15/5 mmHg
		// Heart rate 250 bpm
		// Pusle strength absent

		// END SCENARIO WITH FAIL

		Invoke ("ChangeScene", 3.0f);
	}

	void ChangeScene() {
			if (currentState == 2) {
					Application.LoadLevel ("Success");
			} else {
					Application.LoadLevel ("Failure");
			}
	}
}
