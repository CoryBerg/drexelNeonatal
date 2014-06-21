using UnityEngine;
using System.Collections;

public class CaseInitializer : MonoBehaviour {
	public static CaseInitializer Instance;
	public RespiratoryCase ActiveCase;
	// Use this for initialization
	void Awake () {
		if(Instance != null) {
			Destroy(this.gameObject);
			return;
		}
		Instance = this;
		if(CaseHandler.Instance.currentCase == NeonatalCase.Respiratory) {
			ActiveCase = this.gameObject.AddComponent<RespiratoryCase>();
		} else if(CaseHandler.Instance.currentCase == NeonatalCase.Cardiac) {
			ActiveCase = this.gameObject.AddComponent<CardiacCase>();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
