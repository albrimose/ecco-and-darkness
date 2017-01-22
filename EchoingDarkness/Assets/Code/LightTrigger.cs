using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour {
    public LightingRender LightRenderer;
    public Color LightColor;
    public float ColorSpeed = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            LightRenderer.TargetColor = LightColor;
            LightRenderer.ColorSpeed = ColorSpeed;
        }
    }
}
