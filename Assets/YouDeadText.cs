using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouDeadText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int day = SManager.GetInstance ().survivingDays;
		GetComponent<Text> ().text = day.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
