using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    enum Item { wood, muddy_water, water_bottle, sand, charcoal, meat, fish, potato };

    private int value_hunger,
                value_thirst,
                value_temp;

    private int actionCount;

    private List<int> inventory;

	// Use this for initialization
	void Start () {
        value_hunger = 50;
        value_thirst = 50;
        value_temp   = 50;
        actionCount  = 5;
        inventory = new List<int>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void ChangeHunger(int num) { value_hunger += num; }

    public void ChangeThirst(int num) { value_thirst += num; }

    public void ChangeTemp(int num) { value_temp += num; }

    public void DecreaseActionCount() { --actionCount; }

    public void GetItem(int num) { inventory.Add(num); }

    public void UseItem(int num) { inventory.Remove(num); }
}
