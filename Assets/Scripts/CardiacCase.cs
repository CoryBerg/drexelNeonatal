using UnityEngine;
using System.Collections;

public class CardiacCase : RespiratoryCase {
	// States 
	// 1 = furtherdecomp
	// 2 = win
	// 3 = death
	protected override void Update () {
		heartMonitor.BeatsPerMinute = bpm/4;
		
		if(!isCorrect) {
			timer += Time.deltaTime;
			
			if((timer >= 900.0f) && (currentState == 0)) {
				FurtherDecomp();
			}
			else if((timer >= 1800.0f) && (currentState == 1)) {
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

	protected override void InitialState ()	{
		Sp02 = "75%";
		bloodPressure = "50/25";
		heartRate = "180";
		bpm = 180;
	}

	protected override void BabyDeath () {
		currentState = 3; // death
		Sp02 = "85%";
		bloodPressure = "65/35";
		heartRate = "140";
		bpm = 140;
		// Pulse strength strong
	}

	protected override void BabyRecovery ()	{
		currentState = 2; // win
		Sp02 = "85%";
		bloodPressure = "65/35";
		heartRate = "140";
		bpm = 140;
		// strong pulse
		// cyanosis disabled
	}

	// After 20 minutes without prostaglandin drip
	protected override void FurtherDecomp () {
		currentState = 1;
		Sp02 = "60%";
		// Cyanosis enabled
		// resp rate: 120 b/m
		bloodPressure = "30/10";
		heartRate = "220";
		bpm = 220;
		// weak pulse strength
	}
}
