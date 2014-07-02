using UnityEngine;
using System.Collections;

// Attach to a daikon button and load selected scenario
public class SetScenarioAndLoad : MonoBehaviour {
	public NeonatalCase CaseType;

	public void OnClick( dfControl control, dfMouseEventArgs mouseEvent ) {
		CaseHandler.Instance.ActivateCase(CaseType);
		Application.LoadLevel("IntroRespCase");
	}
}
