using UnityEngine;
using System.Collections;

public class Breathing : MonoBehaviour {
	private float breath;
	private SkinnedMeshRenderer skinMeshRenderer;

	// Use this for initialization
	void Start () {
		skinMeshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		breath = Mathf.Sin(Time.time * 2) *50+50;
		skinMeshRenderer.SetBlendShapeWeight(1, breath);
		skinMeshRenderer.SetBlendShapeWeight(2, breath);
	}
}
