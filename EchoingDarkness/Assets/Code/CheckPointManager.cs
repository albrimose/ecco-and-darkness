using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager {
    public delegate void MyDelegate();
    public static CheckPointManager _Instance = null;
    public static CheckPointManager Instance { get
        {
            if(_Instance == null)
            {
                _Instance = new CheckPointManager();
            }
            return _Instance;
        }
    }
    public event MyDelegate onRestore;
    public event MyDelegate onCheckPoint;
    
    //void Awake()
    //{
    //    if (_Instance == null)
    //    {
    //        _Instance = this;
    //    }
    //    else if (_Instance != this)
    //    {
    //        Destroy(gameObject);
    //    }
    //    DontDestroyOnLoad(gameObject);
    //}

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
 //   void Start () {

 //   }
	
	//// Update is called once per frame
	//void Update () {
	//	if(Instance != null)
 //       {
 //           Debug.Log("instance");
 //       }
	//}
}
