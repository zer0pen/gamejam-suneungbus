using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SManager : MonoBehaviour
{
    private static SManager instance;

	// Datas
	public int heart;

	public int badwater;
	public int beef;
	public int coal;
	public int fish;
	public int potato;
	public int sand;
	public int tree;

	public int fire;
	public int fireMax;
	public int water;
	public int waterMax;
	public int food;
	public int foodMax;

	public int survivingDays;

    public static SManager GetInstance()
    {
        if (!instance)
        {
            instance = (SManager) FindObjectOfType(typeof(SManager));
            if (!instance)
                Debug.LogError("There needs to be one active SManager script on a SManager in your scene.");
        }

        return instance;
    }

    void Awake()
    {
        DontDestroyOnLoad(instance);
        fireMax = ValueTable.GlobalTable.fireMax;
        waterMax = ValueTable.GlobalTable.waterMax;
        foodMax = ValueTable.GlobalTable.foodMax;
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public float getFire() {
		return (float)fire / fireMax;
	}

	public float getWater() {
		return (float)water / waterMax;
	}

	public float getFood() {
		return (float)food / foodMax;
	}

	public int[] getArrayedParams() {
		return new int[] {tree, badwater, sand, coal, potato, fish, beef};
	}
}
