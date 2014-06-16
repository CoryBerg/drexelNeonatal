using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIButtonLogger : MonoBehaviour 
{
	public void OnClick( dfControl control, dfMouseEventArgs mouseEvent )
	{
		if(UILogger.UILog.ContainsKey(control.name)) {
			UILogger.UILog[control.name]++;
		} else {
			UILogger.UILog.Add(control.name,0);
		}
	}
}
