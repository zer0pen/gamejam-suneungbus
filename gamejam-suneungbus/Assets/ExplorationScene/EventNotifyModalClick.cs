using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventNotifyModalClick : MonoBehaviour {

	private ExplorationSceneManager explorationSceneManager;

	// Use this for initialization
	void Start () {
		explorationSceneManager = GameObject.Find ("ExplorationSceneManager").GetComponent<ExplorationSceneManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void confirmClick() {
		explorationSceneManager.cancelModals ();
	}
}
