using UnityEngine;
using System.Collections;

public class QuestionReader : MonoBehaviour {

	public GameObject questionGUI;
	public GameObject aAGUI;
	public GameObject aBGUI;
	public GameObject aCGUI;
	public GameObject aDGUI;


	public class Question{
		public string questionText;
		public string anwerAText;

		public Question(string qText, string aAText){
			questionText = qText;
			anwerAText = aAText;
		}
	}

	public Question[] arrayOfQuestions;

	void Start(){
		arrayOfQuestions = new Question[10];

		for (int i = 0; i < 10; i++) {

			string someQ = "Q number: " + i;
			string someA = "A number: " + i;

			Question freshQ = new Question(someQ, someA);
			arrayOfQuestions[i] = freshQ;
		}
	}
}
