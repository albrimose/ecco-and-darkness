using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarRing : MonoBehaviour {
    public float ExpandSpeed = 1.01f;
    public float ExpandTime = 5f;
    protected float ExpirationTime = 2f;
	// Use this for initialization
	void Start () {
        ExpirationTime = ExpandTime;
	}
	
	// Update is called once per frame
	void Update () {
        if(ExpirationTime <= 0f)
        {
            Destroy(gameObject);
        }

        float expansion = Time.deltaTime * ExpandSpeed;

        transform.localScale += (new Vector3(expansion, expansion, expansion));
        ExpirationTime -= Time.deltaTime;
		
	}
}
