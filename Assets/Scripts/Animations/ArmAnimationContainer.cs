using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArmAnimationContainer {
	public Dictionary<string, string> animations;

	// Use this for initialization
	public ArmAnimationContainer() {
		animations = new Dictionary<string, string> ();
		animations.Add ("", "Idle");
		animations.Add ("ButtonNeedle", "NeedleDecomp");
		animations.Add ("ButtonSteth", "UseStethoscope");
		animations.Add ("ButtonChest", "ChestCompression");
		animations.Add ("ButtonSunctionbaby", "Sunction");
		animations.Add ("ButtonIntubation", "Intubation");
	}

	public string GetAnimation(string key) {
		string tmp;
		if(animations.TryGetValue(key, out tmp))
		{
			return animations[key];
		}
		else
		{
			Debug.Log ("not found");
			return null;
		}

	}
}
