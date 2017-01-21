using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour {
    public delegate void MyDelegate();
    public static CheckPointManager Instance;
    public event MyDelegate onRestore;
    public event MyDelegate onCheckPoint;
    
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void CheckPoint()
    {
        if(onCheckPoint != null)
        {
            onCheckPoint.Invoke();
        }
    }

    public void RestoreLastCheckPoint()
    {
        if(onRestore != null)
        {
            onRestore.Invoke();
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
