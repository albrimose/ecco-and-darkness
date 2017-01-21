using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour {
    public LightingRender LightRenderer;
    public Color LightColor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Hello collision");
        if(col.gameObject.tag == "Player")
        {
            LightRenderer.TargetColor = LightColor;
        }
    }
}
