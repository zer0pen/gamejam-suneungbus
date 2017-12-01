using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            if (GameManager.GetInstance().settingWindow.activeInHierarchy)
            {
                GameManager.GetInstance().CloseSettingWindow();
            }
            else if (GameManager.GetInstance().dayAlert.activeInHierarchy)
            {
                GameManager.GetInstance().dayAlert.SetActive(false);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            GameManager.GetInstance().NextDay();
        }
	}
}
