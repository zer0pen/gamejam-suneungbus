using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager GetInstance()
    {
        if (!instance)
        {
            instance = (GameManager)FindObjectOfType(typeof(GameManager));
            if (!instance)
                Debug.LogError("There needs to be one active GameManager script on a GameManager in your scene.");
        }

        return instance;
    }

    public GameObject inventoryWindow;
    public GameObject dayAlert;
    public GameObject settingWindow;
    public Text text_survivingDays;
    public Slider slider_fire,
                  slider_water,
                  slider_food;

    public GameObject slider_content;
	List<GameObject> slider_items;

    // Use this for initialization
    void Start() {
        text_survivingDays.text = SManager.GetInstance().survivingDays + " 일차";

        slider_fire.value = SManager.GetInstance().fire / 100.0f;
        Debug.Log(SManager.GetInstance().getWater());
        slider_water.value = SManager.GetInstance().getWater();
        slider_food.value = SManager.GetInstance().getFood();

        int[] items = SManager.GetInstance().getArrayedParams();
        slider_items = new List<GameObject>();
        for (int i = 0; i<slider_content.transform.childCount; ++i)
        {
            slider_items.Add(slider_content.transform.GetChild(i).gameObject);
            slider_items[i].transform.GetChild(2).GetComponent<Text>().text = "단 \"" + items[i] + "\"개!";
        }

        SoundManager.GetInstance().PlayBGM();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Return))
            if (inventoryWindow.activeInHierarchy)
                CloseInventory();
            else if (settingWindow.activeInHierarchy)
                CloseSettingWindow();
            else
                Application.Quit();

        if (Input.GetKeyDown("1"))
        {
            SceneManager2.GetInstance().ChangeScene(4);
        }
    }

    public void Inventoryy()
    {
        SoundManager.GetInstance().PlayButton();
        inventoryWindow.SetActive(!inventoryWindow.activeInHierarchy);
    }

    public void CloseInventory()
    {
        SoundManager.GetInstance().PlayButton();
        inventoryWindow.SetActive(false);
    }

    public void OpenSettingWindow()
    {
        SoundManager.GetInstance().PlayButton();
        settingWindow.SetActive(true);
    }

    public void CloseSettingWindow()
    {
        SoundManager.GetInstance().PlayButton();
        settingWindow.SetActive(false);
    }

    public void NextDay()
    {
        dayAlert.SetActive(true);
    }
}
