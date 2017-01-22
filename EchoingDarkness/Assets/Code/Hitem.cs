using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitem : MonoBehaviour {
    public bool triggerd;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        triggerd = true;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
