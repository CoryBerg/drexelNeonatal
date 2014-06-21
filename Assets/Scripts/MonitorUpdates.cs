using UnityEngine;
using System.Collections;

public class MonitorUpdates : MonoBehaviour {

	public RespiratoryCase neonatalCase;
	public string labelName;
	private dfLabel lbl;
	// Use this for initialization
	void Start () {
		neonatalCase = CaseInitializer.Instance.ActiveCase;
		lbl = GetComponent<dfLabel>();
		labelName = gameObject.name;
	}
	
	// Update is called once per frame
	void Update () {
		if(neonatalCase == null) {
		}
		if(neonatalCase == null) {
			return;
		}
		switch (labelName) {
			case "Sp02":
				lbl.Text = neonatalCase.Sp02;
				break;
			case "heartRate":
				lbl.Text = neonatalCase.heartRate;
				break;
			case "bloodPressure":
				lbl.Text = neonatalCase.bloodPressure;
				break;
			case "temperature":
				lbl.Text = neonatalCase.temperature;
				break;
		}
	}
}
