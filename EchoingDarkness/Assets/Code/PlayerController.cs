using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;

    private Rigidbody2D rb;
    public GameObject EchoLight;
    public float EchoSpeed = 20f;
    public float EchoRetract = 5f;
    public float MaxEcho = 20f;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);

        rb.AddForce(movement * speed * Time.deltaTime);

        if(EchoLight != null)
        {
            if(Input.GetButton("Echo"))
            {
                if (EchoLight.transform.localScale.x < MaxEcho)
                {
                    EchoLight.transform.localScale += new Vector3(EchoSpeed * Time.deltaTime, EchoSpeed * Time.deltaTime, EchoSpeed * Time.deltaTime);
                }

            }
            else if(EchoLight.transform.localScale.x > 1)
            {
                EchoLight.transform.localScale -= new Vector3(EchoRetract * Time.deltaTime, EchoRetract * Time.deltaTime, EchoRetract * Time.deltaTime);
            }
        }
    }
}
