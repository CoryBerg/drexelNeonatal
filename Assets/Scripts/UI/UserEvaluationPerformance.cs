using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UserEvaluationPerformance : MonoBehaviour {
	public GameObject labelPrefab;
	public float offset = 2f;
	public Transform root;
	// From gold standard document
	static Dictionary<string, string> _translationDict = new Dictionary<string, string>
	{
		{"ButtonStethLL","Stethoscope"},
		{"ButtonStethLR","Stethoscope"},
		{"ButtonStethUL","Stethoscope"},
		{"ButtonStethUR","Stethoscope"},
		{"ButtonNeedle","Needle Decompression"},
		{"ButtonSuctionbaby","Suction the Baby"},
		{"ButtonTransilL","Transilluminate Chest"},
		{"ButtonETT","Attach ETT"},
		{"ButtonTransilR","Transilluminate Chest"}
	};

	static Dictionary<string, string> _tooltipDict = new Dictionary<string, string>
	{
		{"Stethoscope","You appropriately examined the baby’s chest using a stethoscope, as physical exam should be one of the first steps taken to address any patient demonstrating an acute change in clinical status.  The right side of the patient’ chest clearly demonstrated breath sounds, however, breath sounds were absent on the left side of the chest.  Absent breath sounds on one side of the chest should alert the clinician to the possibility of a pneumothorax on the affected side."},
		{"Debug","Tooltip not implemented!"},
		{"Attach ETT","Asked nurse to attach the ETT to the flow inflating bag to hand bag. Hand bag ventilation in a decompensating mechanically ventilated patient is another important measure to take.  However, this will not improve the clinical status in an infant with a tension pneumothorax."},
		{"Suction the Baby","Suctioning a ventilated infant who is displaying hypoxia is certainly an important measure to uncover the underlying etiology of an acute respiratory decompensation.  In this case, however, suctioning did not change the infant’s clinical picture as it is not a helpful measure in an infant with a tension pneumothorax.  "},
		{"Transilluminate Chest","You correctly decided that transillumination of the chest wall would be an important step in the diagnostic work up of this infant.  When the light source was applied to the axillary region of the left side of the infant’s chest, that side of the chest appeared very bright (as opposed to the right side of the patient’s chest, which only brightened a small amount when the light source was applied).  The finding of the two sides of the chest differing in their appearance in response to a light source is suggestive that the infant may have a pneumothorax on the affected side."},
		{"Needle Decompression","Appropriately performed needle decompression (2nd intercostal space in midclavicular line) performed within 15 minutes.  Excellent job!  You correctly recognized that this infant was suffering from a tension pneumothorax and that the only effective treatment is prompt needle decompression of the affected side of the chest.  Needle decompression is properly performed by introducing a needle into the second intercostal space in the midclavicular line on the affected side, with subsequent release of the trapped air in the extrapleural space."}
	};
	// Use this for initialization
	void Start () {
//		For Debugging in scene...
//		UILogger.ButtonsPressed = new List<string>();
//		UILogger.ButtonsPressed.Add("Jesse");
//		UILogger.ButtonsPressed.Add("James");
//		UILogger.ButtonsPressed.Add("Team Rocket");
//		UILogger.ButtonsPressed.Add("Blasting Off");
//		UILogger.ButtonsPressed.Add("Speed of Light");
//		UILogger.ButtonsPressed.Add("Surrender Now");
//		UILogger.ButtonsPressed.Add("Or Prepare to Fight");
//		UILogger.ButtonsPressed.Add("Meowth, That's Right");
		if(UILogger.ButtonsPressed != null) {
			string textVal = string.Format("{0:D}. {1}", 1, UILogger.ButtonsPressed[0]);
			int c = 1;
			for(int i = 0; i < UILogger.ButtonsPressed.Count; i++) {
				if(UILogger.ButtonsPressed[i].Contains("Exit") || ! _translationDict.ContainsKey(UILogger.ButtonsPressed[i])) {
					continue;
				}
				GameObject labelInst = (GameObject)dfGUIManager.Instantiate(labelPrefab);
				labelInst.transform.parent = this.transform;
				dfLabel lbl = labelInst.GetComponent<dfLabel>();
				lbl.Position = root.transform.position + new Vector3(0,-offset * (c - 1));
				string v = _translationDict[UILogger.ButtonsPressed[i]];
				string tooltip = _tooltipDict.ContainsKey(v) ? _tooltipDict[v] : _tooltipDict["Debug"] + " " + v;
				textVal = string.Format("{0:D}. {1}",c,v);
				lbl.Text = textVal;
				lbl.Tooltip = tooltip;
				c++;
			}
		} else {
			GameObject labelInst = (GameObject)dfGUIManager.Instantiate(labelPrefab);
			labelInst.transform.parent = this.transform;
			labelInst.transform.position = root.transform.position;
			dfLabel lbl = labelInst.GetComponent<dfLabel>();
			lbl.Text = "No data";
			lbl.Tooltip = "No available description.";
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
