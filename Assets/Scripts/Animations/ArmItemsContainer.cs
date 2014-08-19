using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArmItemsContainer {
	private Dictionary<string, List<GameObject>> items;
	
	// Builds dictionary of ButtonPressed:Item
	public ArmItemsContainer() {
		items = new Dictionary<string, List<GameObject>> ()
		{
			{"ButtonNeedle", new List<GameObject>() { GameObject.Find ("butterflyNeedle")}},
			{"ButtonSteth", new List<GameObject>() { GameObject.Find ("stethoscope")}},
			{"ButtonIntubation", new List<GameObject>() { GameObject.Find ("laryngoscope")}},
			{"ButtonSunction", new List<GameObject>() { GameObject.Find ("bagAndMask")}}
		};
	}

	public void NewAnimation(string animation) {
		//DisableAllItems ();
		//EnableItems (animation);
	}

	public void EnableItems(string key) {
		List<GameObject> tmp = null;

		if(items.TryGetValue(key, out tmp)) {
			foreach (GameObject item in tmp) {
				item.SetActive(true);
			}
		}
	}

	public void DisableAllItems() {
		foreach (List<GameObject> list in items.Values) {
			foreach (GameObject item in list) {
				item.SetActive (false);
			}
		}
	}
}
	