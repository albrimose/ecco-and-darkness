using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour {
    protected bool TrapActive = false;
    protected Rigidbody2D rb;
    public float FallSpeed = 2f;
    // Use this for initialization
    void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		if(TrapActive)
        {
            rb.AddForce(new Vector3(0f, -FallSpeed, 0f));
        }
	}

    public void Drop()
    {
        TrapActive = true;
        rb.constraints = RigidbodyConstraints2D.None;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (TrapActive)
        {
            if (col.gameObject.tag == "Player")
            {
                Debug.Log("Death!");
                //TODO: Kill Player.
            }
        }
    }
}
