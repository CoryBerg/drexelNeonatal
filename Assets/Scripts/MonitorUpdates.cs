using UnityEngine;
using System.Collections;

public class MonitorUpdates : MonoBehaviour {
	public dfLabel pressure, hRate, spO2, temp;
	public static MonitorUpdates Instance;
	void Awake() {
		Instance = this;
	}

	public void UpdateMonitor(string so2, string t, string bp, string hr) {
		print ("Monitor Updating");
		spO2.Text = so2;
		temp.Text = t;
		pressure.Text = bp;
		hRate.Text = hr;
	}
}
