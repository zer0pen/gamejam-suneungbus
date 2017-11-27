using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLayerButtonClick : MonoBehaviour {

	private ExplorationSceneManager explorationSceneManager;

	// Use this for initialization
	void Start () {
		explorationSceneManager = GameObject.Find ("ExplorationSceneManager").GetComponent<ExplorationSceneManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void asnapynClick() {
		explorationSceneManager.openExploreConfirmModal (0);
	}

	public void mbClick() {
		explorationSceneManager.openExploreConfirmModal (1);
	}

	public void golrpClick() {
		explorationSceneManager.openExploreConfirmModal (2);
	}

	public void mtpowerClick() {
		explorationSceneManager.openExploreConfirmModal (3);
	}

	public void frmskClick() {
		explorationSceneManager.openExploreConfirmModal (4);
	}
}
