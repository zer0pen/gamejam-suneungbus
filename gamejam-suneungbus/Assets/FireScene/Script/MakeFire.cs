using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeFire : MonoBehaviour {

	private Slider fireSlider;
	private Slider waterSlider;
	private Slider foodSlider;

	private Text treeText;
	private Text timerText;
	private Text heartText;

	private GameObject buttonGameObject;

    public Animator anim;
    public float beforePosX;
    public bool isMakeFire;
//    public float timeLimit;
    float movingTime;

	private int count;
	private float timer;
	private bool isStarted = false;

    // Use this for initialization
    void Start () {
        anim.enabled = false;
        isMakeFire = false;
        beforePosX = 0.0f;

		fireSlider = GameObject.Find("FireSlider").GetComponent<Slider>();
		waterSlider = GameObject.Find("WaterSlider").GetComponent<Slider>();
		foodSlider = GameObject.Find("FoodSlider").GetComponent<Slider>();

		treeText = GameObject.Find ("TreeText").GetComponent<Text> ();
		timerText = GameObject.Find ("TimerText").GetComponent<Text> ();
		heartText = GameObject.Find ("HeartText").GetComponent<Text> ();

		SManager.GetInstance ().tree = 1000;
		timerText.text = (ValueTable.FireMakeScene.timeLimit / 1000).ToString ();
		timer = 0;

		// test
		// SManager.GetInstance ().heart = 5;
		heartText.text = SManager.GetInstance ().heart.ToString () + "/" + ValueTable.GlobalTable.heartMax;
    }
	
	// Update is called once per frame
	void Update () {
		fireSlider.value = SManager.GetInstance ().getFire();
		waterSlider.value = SManager.GetInstance ().getWater();
		foodSlider.value = SManager.GetInstance ().getFood();
		treeText.text = SManager.GetInstance ().tree.ToString();

		if (!isStarted) {
			return;
		}

		if (SManager.GetInstance ().tree > ValueTable.FireMakeScene.clickPerTree) {
			if (Input.GetMouseButton (0) && Mathf.Abs (beforePosX - Input.mousePosition.x) >= 20.0f) {
				isMakeFire = true;
				beforePosX = Input.mousePosition.x;
			} else {
				isMakeFire = false;
			}

			if (movingTime >= 0) {
				// ++
				movingTime = 0.0f;
			}

			if (isMakeFire) {
				movingTime += Time.deltaTime;
				anim.enabled = true;

				count++;
				SManager.GetInstance ().tree -= ValueTable.FireMakeScene.clickPerTree;
				if (count % ValueTable.FireMakeScene.countPerFire == 0) {
					SManager.GetInstance ().fire++;
				}
			} else {
				movingTime = 0.0f;
				anim.enabled = false;   
			}
		}

//		Debug.Log(ValueTable.FireMakeScene.timeLimit + "," + timer);
		if (timer >= (ValueTable.FoodBakingScene.timeLimit / 1000)) {
			endGame ();
			// TODO: End of Scene
		}

		timer += Time.deltaTime;
		timerText.text = Mathf.CeilToInt((ValueTable.FireMakeScene.timeLimit / 1000) - timer).ToString ();
	}

    private void OnCollisionEnter(Collision collision)
    {
        
    }

	public void startGameButton() {
		if (SManager.GetInstance ().heart <= 0) {
			return;
		}

		SManager.GetInstance().heart--;
		heartText.text = SManager.GetInstance ().heart.ToString () + "/" + ValueTable.GlobalTable.heartMax;

        if (SManager.GetInstance().heart == 0)
            SceneManager2.GetInstance().ChangeScene(5);


        timerText.text = (ValueTable.FireMakeScene.timeLimit / 1000).ToString ();
		timer = 0;

		buttonGameObject = GameObject.Find ("StartGameButton");
		buttonGameObject.SetActive (false);
		isStarted = true;
	}

	public void endGame() {
		buttonGameObject.SetActive (true);
		isStarted = false;
	}

	public void backButtonPressed() {
        // TODO;
        SceneManager2.GetInstance().ChangeScene(0);
	}
}
