using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AssemblyCSharp;
public class WinScript : MonoBehaviour {

	//public float maxtime = 300;
	public Text wintext;

	// Use this for initialization
	void Start () {
		//timertext = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {

		if (GlobalVariables.numfreeze >= 1) {
			//print ("inside func");
			SetWinText ();
		}
	}

	void SetWinText()
	{
		wintext.text = "DAN WINS";

	}
}