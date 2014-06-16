using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UILogger : MonoBehaviour {
	
	public static Dictionary<string,int> UILog; // Mapped button to count of times pressed
	// Use this for initialization
	void Start () {
//		dfButton buttons = gameObject.GetComponentsInChildren<
		foreach(dfButton button in gameObject.GetComponentsInChildren(typeof(dfButton))) {
			button.gameObject.AddComponent<UIButtonLogger>();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
