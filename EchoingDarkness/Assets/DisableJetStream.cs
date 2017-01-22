using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableJetStream : MonoBehaviour {
    public GameObject ItemToDisable;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Boulder b = col.gameObject.GetComponent<Boulder>();
        if (b != null)
        {
            ItemToDisable.SetActive(false);
        }

    }
}
