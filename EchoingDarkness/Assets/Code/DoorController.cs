using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    public SwitchControls[] Switches;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        bool isSwitchesPressed = true;
        foreach (SwitchControls s in Switches)
        {
            if(!s.isSwitchActive)
            {
                isSwitchesPressed = false;
                break;
            }
        }

        if(isSwitchesPressed)
        {
            Destroy(gameObject);
        }
	}
}
