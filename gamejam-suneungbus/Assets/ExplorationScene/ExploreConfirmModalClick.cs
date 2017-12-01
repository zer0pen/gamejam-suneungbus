using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploreConfirmModalClick : MonoBehaviour {

	private ExplorationSceneManager explorationSceneManager;

	// Use this for initialization
	void Start () {
		explorationSceneManager = GameObject.Find ("ExplorationSceneManager").GetComponent<ExplorationSceneManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void confirmClick() {
		explorationSceneManager.confirmOnExploreConfirmModal ();
	}

	public void cancelClick() {
		explorationSceneManager.cancelModals ();
	}
}
