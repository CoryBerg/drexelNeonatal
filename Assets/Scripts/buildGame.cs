using UnityEngine;
using System.Collections;

public class guiTest2 : MonoBehaviour {
	public GameObject baby;
 
    public GUISkin leftnav;
 
    void Start() {
    	baby = (GameObject)Instantiate(Resources.Load("MyPrefab"));
    }
}