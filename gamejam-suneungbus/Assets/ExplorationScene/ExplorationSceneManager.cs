using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class ExplorationSceneManager : MonoBehaviour {

	private GameObject mapLayer;
	private GameObject exploreConfirmModal;
	private GameObject eventNotifyModal;

	public Sprite item_badwater;
	public Sprite item_beef;
	public Sprite item_coal;
	public Sprite item_fish;
	public Sprite item_potato;
	public Sprite item_sand;
	public Sprite item_tree;

	private int lastest_index = 0;

	// Use this for initialization
	void Start () {
		mapLayer = GameObject.Find ("MapLayer");
		exploreConfirmModal = GameObject.Find ("ExploreConfirmModal");
		eventNotifyModal = GameObject.Find ("EventNotifyModal");

		mapLayer.SetActive (true);
		exploreConfirmModal.SetActive (false);
		eventNotifyModal.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public void openExploreConfirmModal (int index) {
		lastest_index = index;

		mapLayer.SetActive (false);
		exploreConfirmModal.SetActive (true);

		GameObject content = GameObject.Find ("ExploreConfirmModalContent");
		Text text = content.GetComponent<Text> ();
		text.text = ValueTable.ExplorationTable.incomeContentBefore[index];

		content = GameObject.Find ("ExploreConfirmModalTitle");
		text = content.GetComponent<Text> ();
		text.text = ValueTable.ExplorationTable.incomeTitle[index];
	}

	public Sprite selectSprite(string item) {
		switch (item) {
		case "item_badwater":
			return item_badwater;
		case "item_beef":
			return item_beef;
		case "item_coal":
			return item_coal;
		case "item_fish":
			return item_fish;
		case "item_potato":
			return item_potato;
		case "item_sand":
			return item_sand;
		case "item_tree":
			return item_tree;
		default:
			return null;
		}
	}

	public void confirmOnExploreConfirmModal () {
		int goodEvent = ValueTable.ExplorationTable.incomeCount [lastest_index, 0];
		int badEvent = ValueTable.ExplorationTable.incomeCount [lastest_index, 1]; 

		int total = goodEvent + badEvent;
		int rand = Random.Range (0, total);

		string sprite_0 = ValueTable.ExplorationTable.incomeItems [lastest_index, rand, 0];
		string sprite_1 = ValueTable.ExplorationTable.incomeItems [lastest_index, rand, 1];
		string sprite_2 = ValueTable.ExplorationTable.incomeItems [lastest_index, rand, 2];

		string count_0 = ValueTable.ExplorationTable.incomeDatas [lastest_index, rand, 0].ToString();
		string count_1 = ValueTable.ExplorationTable.incomeDatas [lastest_index, rand, 1].ToString();
		string count_2 = ValueTable.ExplorationTable.incomeDatas [lastest_index, rand, 2].ToString();

		exploreConfirmModal.SetActive (false);
		eventNotifyModal.SetActive (true);

		GameObject content = GameObject.Find ("EventNotifyModalContent");
		Text text = content.GetComponent<Text> ();
		text.text = ValueTable.ExplorationTable.incomeContent[lastest_index, rand];

		content = GameObject.Find ("EventNotifyModalTitle");
		text = content.GetComponent<Text> ();
		text.text = ValueTable.ExplorationTable.incomeTitle[lastest_index];

		content = GameObject.Find ("RewordImage_0");
		Image image = content.GetComponent<Image> ();
		image.sprite = selectSprite (sprite_0);

		content = GameObject.Find ("RewordText_0");
		text = content.GetComponent<Text> ();
		text.text = count_0;

		content = GameObject.Find ("RewordImage_1");
		image = content.GetComponent<Image> ();
		image.sprite = selectSprite (sprite_1);

		content = GameObject.Find ("RewordText_1");
		text = content.GetComponent<Text> ();
		text.text = count_1;

		content = GameObject.Find ("RewordImage_2");
		image = content.GetComponent<Image> ();
		image.sprite = selectSprite (sprite_2);

		content = GameObject.Find ("RewordText_2");
		text = content.GetComponent<Text> ();
		text.text = count_2;

		if (rand >= goodEvent) {
			Debug.Log ("Dead");
			SceneManager2.GetInstance ().ChangeScene (5);
		}
	}

	public void updateUserParams(string input, int count) {
		switch (input) {
		case "item_tree":
			SManager.GetInstance ().tree += count;
			break;
		case "item_beef":
			SManager.GetInstance ().beef += count;
			break;
		case "item_badwater":
			SManager.GetInstance ().badwater += count;
			break;
		case "item_sand":
			SManager.GetInstance ().sand += count;
			break;
		case "item_fish":
			SManager.GetInstance ().fish += count;
			break;
		case "item_coal":
			SManager.GetInstance ().coal += count;
			break;
		case "item_potato":
			SManager.GetInstance ().potato += count;
			break;
		}
	}

	public void cancelModals () {
		mapLayer.SetActive (true);
		exploreConfirmModal.SetActive (false);
		eventNotifyModal.SetActive (false);
	}

}
