using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArmItemsContainer {
	private Dictionary<string, GameObject> items;
	
	// Builds dictionary of ButtonPressed:Item
	public ArmItemsContainer() {
		items = new Dictionary<string, GameObject> ()
		{
			{"ButtonNeedle", GameObject.Find ("butterflyNeedle")},
			{"ButtonSteth", GameObject.Find ("stethoscope")},
			//{"ButtonIntubation", GameObject.Find ("laryngoscope")},
		};
	}

	public void EnableItem(string key) {
		DisableAllItems ();

		GameObject tmp = null;

		if(items.TryGetValue(key, out tmp)) {
			items[key].SetActive(true);
		}
	}

	public void DisableAllItems() {
		foreach(GameObject item in items.Values)
		{
			item.SetActive(false);
		}
	}
}
	