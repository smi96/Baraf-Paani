using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AssemblyCSharp;
using System;
using System.Linq;

public class Winner : MonoBehaviour {

	public Text timertext;
	public Text wintext;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		print (timertext.text);
		if (GlobalVariables.numfreeze >= GlobalVariables.numplayers - 1)
			wintext.text = "Police Wins";
		if (Int32.Parse(timertext.text) < 1) {
			wintext.text = "Robbers win";
		}
	}

}
