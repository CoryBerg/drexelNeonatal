using UnityEngine;
using System.Collections;
using System.Xml;

public class GuiTest : MonoBehaviour {
	public bool visible = false;
	public string clipText = "Show Clipboard";
	public Animator baby;
	public int test = Screen.width/3;
	
	private Rect clipboard = new Rect(0, Screen.height-25, Screen.width/3, 397);
	private Rect showHide = new Rect(0, Screen.height-25, Screen.width/3, 25);

	public Texture clipTexture;
	public GUIStyle clipStyle = new GUIStyle();
	
	public XmlDocument root;
	public string filepath;
		
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
         		ReadXML(1);
         		
       		}
       		if(GUI.Button(new Rect(((Screen.width/3)/3)-25, Screen.height-clipboard.height+100, 100, 25), "Play Anim2")) {
         		// Play Animation 2
         		ReadXML(2);
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
	
	public void Start() {
		root = new XmlDocument();
		root.Load(filepath);
	}
	
	public void ReadXML(int babyState) {
		string anim = root.SelectSingleNode("babyStates/baby[@id='" + babyState + "']/animation").InnerText;
		
		baby.Play(anim);
	}
}
