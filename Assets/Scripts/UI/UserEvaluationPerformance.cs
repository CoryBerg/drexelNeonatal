﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UserEvaluationPerformance : MonoBehaviour {
	private dfLabel lbl;
	// Use this for initialization
	void Start () {
		lbl = this.GetComponent<dfLabel>();
//		For Debugging in scene...
//		UILogger.ButtonsPressed = new List<string>();
//		UILogger.ButtonsPressed.Add("Jesse");
//		UILogger.ButtonsPressed.Add("James");
//		UILogger.ButtonsPressed.Add("Team Rocket");
//		UILogger.ButtonsPressed.Add("Blasting Off");
//		UILogger.ButtonsPressed.Add("Speed of Light");
//		UILogger.ButtonsPressed.Add("Surrender Now");
//		UILogger.ButtonsPressed.Add("Or Prepare to Fight");
//		UILogger.ButtonsPressed.Add("Meowth, That's Right");
		if(UILogger.ButtonsPressed != null) {
			string textVal = string.Format("{0:D}. {1}", 1, UILogger.ButtonsPressed[0]);
			for(int i = 1; i < UILogger.ButtonsPressed.Count; i++) {
				textVal = string.Format("{0}\n{1:D}. {2}",textVal,i + 1,UILogger.ButtonsPressed[i]);
			}
			lbl.Text = textVal;
		} else {
			lbl.Text = "1. No Data.";
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}