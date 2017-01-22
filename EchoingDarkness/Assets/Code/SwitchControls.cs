using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControls : MonoBehaviour {

    public float SwitchActivationTime = 2f;
    public Sprite SwitchInactiveSprite;
    public Sprite SwitchActiveSprite;
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
            //sr.color = SwitchActiveColor;
            sr.sprite = SwitchActiveSprite;
            TimeActive -= Time.deltaTime;
        }
        else
        {
            sr.sprite = SwitchInactiveSprite;
            //sr.color = SwitchInactiveColor;
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
