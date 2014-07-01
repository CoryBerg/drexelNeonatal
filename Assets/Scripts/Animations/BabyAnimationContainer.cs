using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BabyAnimationContainer {
	private Dictionary<string, float> animations;

	// Builds dictionary of ButtonPressed:AnimationName
	public BabyAnimationContainer() {
		animations = new Dictionary<string, float> ()
			{
				{"Idle", 0.0f},
				{"ButtonNeedle", 0.0f},
				{"ButtonSteth", -1.0f},
				{"ButtonChest", -1.0f},
				{"ButtonSunctionbaby", 0.0f},
				{"ButtonIntubation", 1.0f},
			};
	}

	public float GetAnimation(string key) {
		return animations[key];
	}
}
