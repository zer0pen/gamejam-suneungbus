using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSound : MonoBehaviour {
    public static ToggleSound instance;
    public bool isMute = false;
    void Start()
    {
        instance = this;
    }
    public void VolumeMute()
    {
        isMute = !isMute;
    }
}
