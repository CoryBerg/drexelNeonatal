using UnityEngine;
using System.Collections;

public class Transillumination : MonoBehaviour {
	
	public Transform target ;
	public float damping = 6;
	public bool isTriggered = false; 
	//public GameObject ; 
	////@script AddComponentMenu("Camera-Control/Smooth Look At")
	
	void Update () {
		
		
		if (target) {
			if (isTriggered)
			{
				// Look at and dampen the rotation
				var rotation = Quaternion.LookRotation(target.position - transform.position);
				transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
			}
			else
			{
				// Just lookat
				transform.LookAt(target);
			}
		}
	}
	
	void Start () {
	}	

	public void OnClick(dfControl control, dfMouseEventArgs mouseEvent) {
		Debug.Log (this.transform.name);

		isTriggered = true;
		
	}
	
}