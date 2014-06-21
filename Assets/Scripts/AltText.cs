using UnityEngine;
using System.Collections;

public class AltText : MonoBehaviour {
	public NeonatalCase CaseToShow;
	public dfLabel labelToModify;
	public string value;
	// Use this for initialization
	void Start () {
		if(labelToModify == null) {
			labelToModify = this.GetComponent<dfLabel>();
		}
		if(CaseHandler.Instance.currentCase == CaseToShow) {
			labelToModify.Text = value;
		}
	}
}
