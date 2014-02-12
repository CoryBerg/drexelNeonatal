using UnityEngine;
using System.Collections;

public class RotateView : MonoBehaviour {

	GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Tab)) {
			transform.Rotate(Vector3.down * 90);
		}
	}
}
