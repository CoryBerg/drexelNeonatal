using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestHandler : MonoBehaviour {
	// Use this for initialization
	public dfLabel lbl;
	public Dictionary<string,bool> TestsCompleted; // if dict has key, it's in progress, if not--not started.
	public static TestHandler Instance;
	public dfTweenFloat tweener, reverseTweener;
	// If true... results are available

	public class TestStuff {
		public string name;
		public float length;
		public TestStuff (string n, float l) {
			this.name = n;
			this.length = l;
		}
	}


	void Start () {
		TestsCompleted = new Dictionary<string, bool>();
		Instance = this;
	}

	public void BeginTest(string testName, float testLength) {
		StartCoroutine("DoTest",new TestStuff(testName,testLength));
	}

	public IEnumerator ResultsSoon() {
		
		lbl.Text = "Results Available Soon";
		// This tweening will be buggy.
		if(!tweener.IsPlaying) {
			tweener.Play();
		}
		yield return new WaitForSeconds(4.5f);
		if(!reverseTweener.IsPlaying) {
			reverseTweener.Play();
		}
	}

	IEnumerator DoTest(TestStuff aTest) {
		TestsCompleted[aTest.name] = false;
		yield return new WaitForSeconds(aTest.length);
		TestsCompleted[aTest.name] = true;
		lbl.Text = aTest.name + " Results Available";
		// This tweening will be buggy.
		if(!tweener.IsPlaying) {
			tweener.Play();
		}
		yield return new WaitForSeconds(4.5f);
		if(!reverseTweener.IsPlaying) {
			reverseTweener.Play();
		}
	}



	public bool TestStatus(string testName) {
		if(!TestsCompleted.ContainsKey(testName)) {
			return false;
		}
		return TestsCompleted[testName];
	}

	public bool TestInProgressButNotComplete(string testName) {
		return TestsCompleted.ContainsKey(testName) && !TestsCompleted[testName];
	}
}
