using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerScript : MonoBehaviour {

	public float maxtime = 10;
	public Text timertext;

	// Use this for initialization
	void Start () {
		timertext = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		maxtime -= Time.deltaTime;
		timertext.text = maxtime.ToString ("f0");
		if (maxtime < 0)
			maxtime = 0;
	}
}
