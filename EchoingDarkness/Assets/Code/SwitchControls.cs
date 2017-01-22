using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControls : MonoBehaviour {

    public float SwitchActivationTime = 2f;
    public Color SwitchInactiveColor = Color.cyan;
    public Color SwitchActiveColor = Color.magenta;
    protected float TimeActive = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
    public bool isSwitchActive
    {
        get
        {
            return TimeActive > 0f;
        }
    }

	// Update is called once per frame
	void Update () {
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        if (TimeActive > 0f)
        {
            sr.color = SwitchActiveColor;
            TimeActive -= Time.deltaTime;
        }
        else
        {
            sr.color = SwitchInactiveColor;
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerLight")
        {
            TimeActive = SwitchActivationTime;
        }

    }
}
