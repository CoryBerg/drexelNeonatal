using UnityEngine;
using System.Collections;

public class CorrectChoice : MonoBehaviour {

		void OnClick(){
			Camera.main.GetComponent<RespiratoryCase>().isCorrect = true;
		}

}
