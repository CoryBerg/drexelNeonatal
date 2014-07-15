using UnityEngine;
using System.Collections;

public class ChestCompressionController : MonoBehaviour {
	public dfButton[] mainButtons;
	public ArmAnimatorController animController;

	public void HideMainButtons() {
		ButtonChange(false);
	}

	void ButtonChange(bool on) {
		foreach(dfButton b in mainButtons) {
			b.IsVisible = on;
		}
	}

	public void BeginCompression() {
		// starts compression or continues if it's already going
	}

	public void StopCompression() {
		// ends compression, closes controls
		ButtonChange(true);
	}
}
