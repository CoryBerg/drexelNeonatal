// This will be heavily refactored.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArmSpecialCase {
	public GameObject arms = GameObject.Find ("arms");

	private Dictionary<string, string> actions;

	public void EnableSpecialCaseItem(ArmItemsContainer items) {
		items.EnableItem ("Intubation");
		arms.transform.Rotate (new Vector3(0,90,0));
	}

	public void ReturnToInitial() {
		arms.transform.Rotate (new Vector3(0,-90,0));
	}
}
