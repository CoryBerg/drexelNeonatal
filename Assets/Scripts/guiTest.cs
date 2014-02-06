using UnityEngine;
using System.Collections;

public class guiTest : MonoBehaviour {
	public bool visible = false;
	public string clipText = "Show Clipboard";
	public Animator baby;
	public int test = Screen.width/3;
	
	private Rect clipboard = new Rect(0, Screen.height-25, Screen.width/3, 397);
	private Rect showHide = new Rect(0, Screen.height-25, Screen.width/3, 25);

	public Texture clipTexture;
	public GUIStyle clipStyle = new GUIStyle();
	
	void OnGUI() {
		GUI.DrawTexture(clipboard, clipTexture, ScaleMode.ScaleToFit, true);
		
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
    		if(GUI.Button(new Rect(((Screen.width/3)/3)-25, Screen.height-clipboard.height+50, 100, 25), "Play Anim1")) {
         		// Play Animation 1
         		baby.Play("Take 001");
         		
       		}
       		if(GUI.Button(new Rect(((Screen.width/3)/3)-25, Screen.height-clipboard.height+100, 100, 25), "Play Anim2")) {
         		// Play Animation 2
         		baby.Play("anim01");
       		}
    	}
	}
	
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
