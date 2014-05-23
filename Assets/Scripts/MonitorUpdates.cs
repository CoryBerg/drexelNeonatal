using UnityEngine;
using System.Collections;

public class MonitorUpdates : MonoBehaviour {

	public GameObject respiratoryCase;
	public string labelName;

	// Use this for initialization
	void Start () {
		respiratoryCase = GameObject.Find ("Player");
		labelName = gameObject.name;
	}
	
	// Update is called once per frame
	void Update () {
		switch (labelName) {
			case "Sp02":
				GetComponent<dfLabel>().Text = respiratoryCase.GetComponent<RespiratoryCase> ().Sp02;
				break;
			case "heartRate":
				GetComponent<dfLabel>().Text = respiratoryCase.GetComponent<RespiratoryCase> ().heartRate;
				break;
			case "bloodPressure":
				GetComponent<dfLabel>().Text = respiratoryCase.GetComponent<RespiratoryCase> ().bloodPressure;
				break;
			case "temperature":
				GetComponent<dfLabel>().Text = respiratoryCase.GetComponent<RespiratoryCase> ().temperature;
				break;
		}
	}
}
