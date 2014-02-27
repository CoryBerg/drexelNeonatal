using UnityEngine;
using System.Collections;
using System.Xml;

public class GuiControl : MonoBehaviour {
	public GameObject baby;

	private Rect clipboard = new Rect(0, Screen.height-25, Screen.width/3, 397);
	private Rect showHide = new Rect(0, Screen.height-25, Screen.width/3, 25);
	
	private bool visible = false;
	private string clipText = "Show Clipboard";


	// Temporary GUI buttons
	void OnGUI() {		
		if(GUI.Button(showHide, clipText)) {
			if(visible) {
				MoveClipboard(true);
				visible = false;
			}
			else if(!visible) {
				MoveClipboard(false);
				visible = true;
			}
		}
		
		if(visible) {
    		if(GUI.Button(new Rect(25, Screen.height-clipboard.height+50, 100, 25), "T Pose")) {
    			// Transitions to T-pose, default state
         		baby.GetComponent<BabyAnimatorController>().currentState = 0;
       		}
       		if(GUI.Button(new Rect(25, Screen.height-clipboard.height+100, 100, 25), "Struggling")) {
         		// Transistions to struggling
         		baby.GetComponent<BabyAnimatorController>().currentState = 1;
       		}
    	}
	}
	
	// Open and close temporary clipboard
	void MoveClipboard(bool visible) {
		if(visible) {
			clipboard.y += clipboard.height;
			clipText = "Show Clipboard";
		}
		else {
			clipboard.y -= clipboard.height;
			clipText = "Hide Clipboard";
		}
	}
}
