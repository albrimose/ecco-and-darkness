using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour {
    protected bool TrapActive = false;
    protected Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(TrapActive)
        {

        }
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (TrapActive)
        {
            if (col.gameObject.tag == "Player")
            {
                //TODO: Kill Player.
            }
        }
    }
}
