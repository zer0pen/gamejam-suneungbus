using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeManager : MonoBehaviour {

	private Image actualObjectImage;

	private int maxData;
	private int nowData;

	// Use this for initialization
	void Start () {
		string objectName = name;
		objectName += "Actual";

		setGameObjectName (objectName);
		if (name == "FireGauge") {
			maxData = ValueTable.GlobalTable.fireMax;
			nowData = SManager.GetInstance ().fire;
		} else if (name == "WaterGauge") {
			maxData = ValueTable.GlobalTable.waterMax;
			nowData = SManager.GetInstance ().water;
		} else if (name == "FoodGauge") {
			maxData = ValueTable.GlobalTable.foodMax;
			nowData = SManager.GetInstance ().food;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (actualObjectImage == null) {
			return;
		}

		if (name == "FireGauge") {
			nowData = SManager.GetInstance ().fire;
		} else if (name == "WaterGauge") {
			nowData = SManager.GetInstance ().water;
		} else if (name == "FoodGauge") {
			nowData = SManager.GetInstance ().food;
		}
			
		float percent = (float) nowData / maxData;
		if (percent >= 1f) {
			if (percent >= 1f) {
				percent = 1f;
			}
			actualObjectImage.color = Color.red;
		} else if (percent <= 0.1f) {
			if (percent <= 0f) {
				percent = 0f;
			}
			actualObjectImage.color = Color.red;
		} else {
			actualObjectImage.color = Color.green;
		}
	
		actualObjectImage.transform.localScale = new Vector3 (1, percent, 1);
	}

	public void setGameObjectName(string name) {
		actualObjectImage = GameObject.Find (name).GetComponent<Image>();
	}

	public void setMaxData(int input) {
		maxData = input;
	}

	public void setNowData(int input) {
		nowData = input;
	}
}
