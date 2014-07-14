using UnityEngine;
using System.Collections;

public class DoTest : MonoBehaviour {
	public string TestName;
	public float TestLength;
	public dfPanel resultPanel;
	public dfPanel testPanel;

	public void OnClick(dfControl control, dfMouseEventArgs mouseEvent) {
		print ("NHGGN");
		if(TestHandler.Instance.TestStatus(TestName)) {
			resultPanel.IsVisible = true;
			testPanel.IsVisible = false;
		} else if(!TestHandler.Instance.TestInProgressButNotComplete(TestName)) {
			TestHandler.Instance.BeginTest(TestName,TestLength);
		} else {
			TestHandler.Instance.StartCoroutine("ResultsSoon");
			// Should do something if it's already in progress
		}
	}
}
