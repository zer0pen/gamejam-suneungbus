using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager2 : MonoBehaviour
{
	private static SceneManager2 instance;
	public static SceneManager2 GetInstance()
	{
		if (!instance)
		{
			instance = (SceneManager2)FindObjectOfType(typeof(SceneManager2));
			if (!instance)
				Debug.LogError("There needs to be one active GameManager script on a GameManager in your scene.");
		}

		return instance;
	}

	void Awake()
	{
		DontDestroyOnLoad(instance);
	}

	public void ChangeScene(int num)
	{
		switch (num)
		{
		case 0: SceneManager.LoadScene("MainScene"); break;
		case 1: SceneManager.LoadScene("FireScene"); break;
		case 2: SceneManager.LoadScene("WaterFilteringScene"); break;
		case 3: SceneManager.LoadScene("FoodBakingScene"); break;
		case 4: SceneManager.LoadScene("ExplorationScene"); break;
		case 5: SceneManager.LoadScene("DeadScene"); break;
		}
	}
}
