using UnityEngine;
using System.Collections;

public class ArmAnimationProcessor : MonoBehaviour {
	public string Idle(string data)
	{
		return data;
	}

	public string NeedleDecomp(string data)
	{
		return "Brandsma" + data;
	}
	
	public string UseStethoscope(string data)
	{
		return "Grundy" + data;
	}
	
	public string ChestCompression(string data)
	{
		return "Nickols" + data;
	}
	
	public string Sunction(string data)
	{
		return "Starr" + data;
	}
	
	public string Intubation(string data)
	{
		return "Rasa" + data;
	}
}
