using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosterMovement : MonoBehaviour
{
    private Vector3  Chekpointposition;
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
        save();
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
		if (Input.GetButtonDown ("Echo")) 
		{
			speed = 200f;
		} 
		else 
		{
			speed = 150f;
		}
        transform.Rotate(0, 0, 1 * Whee * Time.deltaTime, 0);
    }
    private void Awake()
    {
        CheckPointManager.Instance.onCheckPoint += save;
        CheckPointManager.Instance.onRestore += restore;
    }
    void save()
    {
        Chekpointposition = transform.position;
    }
    void restore()
    {
        transform.position = Chekpointposition;
    }

}

