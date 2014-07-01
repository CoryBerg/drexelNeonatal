﻿using UnityEngine;
using System.Collections;

// Also acting as parent class for all cases
public class RespiratoryCase : MonoBehaviour {
	public Animator baby;
	public bool isCorrect = false;
	public float timer = 0.0f;


	public int bpm;
	public string heartRate, Sp02, bloodPressure, temperature;
	protected float decompTimer, deathTimer;
	public int currentState = 0;
	protected SWP_HeartRateMonitor heartMonitor;
	private float firstTime = 3f;
	/*
	*	States:
	*		0 - Initial
	*		1 - No action 5 minutes or improper needle decomp
	*		2 - Correct needle decomp, baby healthy
	*		3 - No action 10 minutes, or improper needle decomp x2
	*/
	protected virtual void Awake() {
		InitialState();
		decompTimer = 300f;
		deathTimer = 600f;
		heartMonitor = GameObject.Find("HeartMonitor").GetComponent<SWP_HeartRateMonitor>();
	}

	protected virtual void Start() {
		StartCoroutine(DecompState());
		StartCoroutine(DeathCondition());
		StartCoroutine(WinCondition());
	}

	protected virtual IEnumerator WinCondition() {
		while(!isCorrect) {
			yield return 0;
		}
		BabyRecovery();
		StopCoroutine("DeathCondition");
		StopCoroutine("DecompState");
	}

	protected virtual IEnumerator DecompState() {
		float time = 0f;
		while(time < decompTimer) {
			time += Time.deltaTime;
			yield return 0;
		} // Wait 300 seconds, if still in state 0--decomp the baby.
		if(currentState == 0) {
			FurtherDecomp();
		}
	}
	
	protected virtual IEnumerator DeathCondition() {
		yield return new WaitForSeconds(deathTimer); // if 
		if(currentState != 2) { // If you haven't won after death time is up... kill the baby
			BabyDeath();
		}
	}

	// Update is called once per frame
	protected virtual void Update () {
		heartMonitor.BeatsPerMinute = bpm;///4;
	}

	protected void UpdateMonitor() {
		MonitorUpdates.Instance.UpdateMonitor(Sp02,temperature,bloodPressure,heartRate);
	}
	
	// Initial state of baby
	protected virtual void InitialState() {
		// Chest retractions
		// Nasal flaring
		// Grunting
		
		// No breathing sounds
		// Blue color around lips
		// Left chest does not move
		
		// PIP 30, PEEP, Rate 45
		// FIO2 100%
		
		// SpO2 75%
		Sp02 = "75%";
		// Temperature 37.1 C
		temperature = "37.1";
		// Respiratory Rate 90 breathes/min
		//respRate = "90";
		// Blood pressure 50/25 mmHg
		bloodPressure = "50/25";
		// Heart rate
		heartRate = "180";
		bpm = 180;
		// Pulse strength weak
		UpdateMonitor();
	}
	
	// No needle decomp by 5 min (regardless of interations or lack thereof) or needle decomp in incorrect location
	protected virtual void FurtherDecomp() {
		currentState = 1;
		// Chest retraction
		// Nasal flaring
		// Grunting
		
		// SpO2 60%
		Sp02 = "60%";
		// Cyanosis enabled
		// Respiratory rate 120 breathes/min
		//respRate = "120";
		// Blood pressure 30/10 mmHg
		bloodPressure = "30/10";
		// Heart rate 220bpm
		bpm = 220;
		heartRate = "220";
		// Pulse strength weak
		UpdateMonitor();
	}
	
	// Needle decomp by 5 min in correct location
	protected virtual void BabyRecovery() {
		currentState = 2;
		
		// No retrations
		// No nasal flaring
		// No grunting
		
		// SpO2 94%
		Sp02 = "94%";
		// Cyanosis disabled
		// Respiratory rate 40 breathes/min
		//respRate = "40";
		// Blood pressure 65/35 mmHg
		bloodPressure = "65/35";
		// Heart rate 140 bpm
		bpm = 140;
		heartRate = "140";
		// Pulse strength strong
		
		// END SCENARIO WITH WIN
		
		//baby.GetComponent<BabyAnimatorController>().currentState = "";
		
		Invoke ("ChangeScene", 3.0f);
		UpdateMonitor();
	}
	
	// No needle decomp by 10 min (5+5, regardless of interations or lack thereof) or needle decomp in incorrect location
	protected virtual void BabyDeath() {
		currentState = 3;
		
		// Lethargic
		// No chest retrations
		// No nasal flaring
		// No grunting
		
		// SpO2 30%
		Sp02 = "30%";
		// Cyanosis enabled
		// Respiratory rate 60 breathes/min
		//respRate = "60";
		// Blood pressure 15/5 mmHg
		bloodPressure = "15/5";
		// Heart rate 250 bpm
		bpm = 250;
		heartRate = "250";
		// Pusle strength absent
		
		// END SCENARIO WITH FAIL
		
		Invoke ("ChangeScene", 3.0f);
		UpdateMonitor();
	}

	// Overridable, cardiac case and any future cases may not always do the same thing or activate specific scenarios
	protected virtual void ChangeScene() {
		if (currentState == 2) {
			CaseHandler.Instance.ActivateCardiac(); // Beating this activates the cardiac test.
			Application.LoadLevel ("Success");
		} else {
			Application.LoadLevel ("Failure");
		}
	}
}