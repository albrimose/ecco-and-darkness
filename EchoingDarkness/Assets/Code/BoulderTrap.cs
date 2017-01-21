using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderTrap : MonoBehaviour {
    
    public Boulder boulder;
    void Awake()
    {
        CheckPointManager.Instance.onRestore += OnRestore;
    }
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnRestore()
    {
        boulder.Reset();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            boulder.Drop();
            
        }
    }
}
