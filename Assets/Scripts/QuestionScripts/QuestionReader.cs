using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class QuestionReader : MonoBehaviour {
	
	
	public GameObject questionGUI;
	public GameObject aAGUI;
	public GameObject aBGUI;
	public GameObject aCGUI;
	public GameObject aDGUI;
	
	public bool aPressed = false;
	public bool bPressed = false;
	public bool cPressed = false;
	public bool dPressed = false;
	
	public int qNumber = 0;
	
	public Question[] arrayOfQuestions;
	
	// a question class with constructors
	public class Question{
		public string questionText;
		public string anwerAText;
		public string anwerBText;
		public string anwerCText;
		public string anwerDText;
		
		public Question(string qText, string aAText, string aBText, string aCText, string aDText){
			questionText = qText;
			anwerAText = aAText;
			anwerBText = aBText;
			anwerCText = aCText;
			anwerDText = aDText;
			
		}
		
		public Question(){
			questionText = "qText";
			anwerAText = "aAText";
			anwerBText = "aBText";
			anwerCText = "aCText";
			anwerDText = "aDText";
		}
	}
	
	
	// initialize question class array
	
	void Start(){
		arrayOfQuestions = new Question[10];
		
		
		arrayOfQuestions[0] = new Question("Number of post graduate training years", "One", "Two", "Three", "Four and beyond");
		arrayOfQuestions[1] = new Question("Current Career goals", "Gen Peds", "Outpatient subspecialty care", "Inpatient subspecialty care", "Other");
		arrayOfQuestions[2] = new Question("Current comfort level in managing  a patient with a tension pneumothorax?", "Very comfortable", "Somewhat comfortable", "Somewhat uncomfortable", "Very uncomfortable");
		
		//initialize Discriptions of the first question
		questionGUI.GetComponent<dfLabel> ().Text = arrayOfQuestions [qNumber].questionText;
		aAGUI.GetComponent<dfButton> ().Text = arrayOfQuestions [qNumber].anwerAText;
		aBGUI.GetComponent<dfButton> ().Text = arrayOfQuestions [qNumber].anwerBText;
		aCGUI.GetComponent<dfButton> ().Text = arrayOfQuestions [qNumber].anwerCText;
		aDGUI.GetComponent<dfButton> ().Text = arrayOfQuestions [qNumber].anwerDText;
		
		//        for (int i = 0; i < 10; i++) {
		//
		//            string someQ = "Q number: " + i;
		//            string someA = "A number: " + i;
		//
		//            Question freshQ = new Question(someQ, someA);
		//            arrayOfQuestions[i] = freshQ;
		//        }
	}
	
	void Update(){
		// check if a button is pressed
		if (aPressed) {
			NextQuestion();
			aPressed = false;
		}

		if (bPressed) {
			NextQuestion();
			bPressed = false;
		}

		if (cPressed) {
			NextQuestion();
			cPressed = false;
		}

		if (dPressed) {
			NextQuestion();
			cPressed = false;
		}

	}

	void NextQuestion(){
		if (qNumber >= 9) {
			LoadLevel();
		}

		qNumber ++;
		questionGUI.GetComponent<dfLabel> ().Text = arrayOfQuestions [qNumber].questionText;
		aAGUI.GetComponent<dfButton> ().Text = arrayOfQuestions [qNumber].anwerAText;
		aBGUI.GetComponent<dfButton> ().Text = arrayOfQuestions [qNumber].anwerBText;
		aCGUI.GetComponent<dfButton> ().Text = arrayOfQuestions [qNumber].anwerCText;
		aDGUI.GetComponent<dfButton> ().Text = arrayOfQuestions [qNumber].anwerDText;


	}

	void LoadLevel(){
		Application.LoadLevel ("Evaluation");
	}

}