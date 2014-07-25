using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArmItemsContainer {
	private Dictionary<string, GameObject> items;
	
	// Builds dictionary of ButtonPressed:Item
	public ArmItemsContainer() {
		items = new Dictionary<string, GameObject> ()
		{
			//{"ButtonNeedle", GameObject.Find ("butterflyNeedle")},
			//{"ButtonSteth", GameObject.Find ("stethoscope")},
			{"ButtonIntubation", GameObject.Find ("laryngoscope")},
			//{"Intubation", GameObject.Find ("endotrachealTube")},
			{"ButtonSunction", GameObject.Find ("bagAndMask")}
		};
	}

	public void NewAnimation(string animation) {
		DisableAllItems ();
		EnableItem (animation);
	}

	public void EnableItem(string key) {
		GameObject tmp = null;

		if(items.TryGetValue(key, out tmp)) {
			items[key].SetActive(true);
		}
	}

	public void DisableAllItems() {
		foreach (GameObject item in items.Values) {
			item.SetActive (false);
		}
	}
}
	