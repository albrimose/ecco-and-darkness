using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosterMovement : MonoBehaviour
{
    //check if target is near
    public bool lockontarget;
    //public GameObject Hunted;
    private Rigidbody2D hunter;
    public float speed = 150f;
    public Transform target;
    public float Whee;
    // Use this for initialization
    void Start()
    {
        hunter = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 direction = target.position - this.transform.position;
            direction = direction.normalized;
            hunter.AddForce(direction * speed * Time.deltaTime);
        }
        transform.Rotate(0, 0, 1 * Whee * Time.deltaTime, 0);
    }
}

