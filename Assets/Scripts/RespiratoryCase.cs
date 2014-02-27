using UnityEngine;
using System.Collections;

public class RespiratoryCase : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		GUI.Box(new Rect(Screen.width/3, 0, (Screen.width/3)+50, 50), 
			"2 day old male infant born at 39 weeks gestation who required endotracheal intubation and mechanical\n" +
			"ventilation on the first day of life for respiratory failure secondary to meconium aspiration.");

		if(GUI.Button(new Rect(Screen.width - 200, 0, Screen.width, 50), "Begin Scenario")) {
			Time.timeScale = 1;
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
	}

	// No needle decomp by 10 min (5+5, regardless of interations or lack thereof) or needle decomp in incorrect location
	void BabyDeath() {
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
	}
}
