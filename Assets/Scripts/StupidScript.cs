using UnityEngine;
using System.Collections;

public class StupidScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Camera>().clearFlags = CameraClearFlags.Skybox;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
