using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetStream : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("JetStream");
            Rigidbody2D rbother = col.gameObject.GetComponent<Rigidbody2D>();
            rbother.AddForce(Vector2.up, ForceMode2D.Impulse);
        }
    }
}
