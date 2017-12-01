using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayChangeManager : MonoBehaviour
{
    private static DayChangeManager instance;
    
    public Text contentText;
    // public GameObject object;

    public static DayChangeManager GetInstance()
    {
        if (!instance)
        {
            instance = (DayChangeManager)FindObjectOfType(typeof(DayChangeManager));
            if (!instance)
                Debug.LogError("There needs to be one active DayChangeManager script on a DayChangeManager in your scene.");
        }

        return instance;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Result()
    {
        int num = 0;

        //if (SManager.GetInstance().fire.Equals(0))
        //{

        //}
        //else if (SManager.GetInstance().fire.Equals(100))
        //{

        //}

        //else if (SManager.GetInstance().water.Equals(0))
        //{

        //}
        //else if (SManager.GetInstance().water.Equals(100))
        //{

        //}

        //else if (SManager.GetInstance().food.Equals(0))
        //{

        //}
        //else if (SManager.GetInstance().food.Equals(100))
        //{

        //}
        //else
        //{
        //    num = Random.Range(0, 4);
            
            
        //}

    }
}
