// This will be heavily refactored after today's meeting.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArmSpecialCase : MonoBehaviour {
	private Dictionary<string, string> actions;
	public GameObject arms = GameObject.Find ("arms");

	public void EnableSpecialCaseItem(ArmItemsContainer items) {
		items.EnableItem ("Intubation");
		arms.transform.Rotate(new Vector3(0,90,0));
	}
	public void ReturnToInitial() {
		arms.transform.Rotate(new Vector3(0,-90,0));
	}
}
