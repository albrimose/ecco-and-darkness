using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour {

    public AudioClip MusicClip;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerController pc = col.gameObject.GetComponent<PlayerController>();
            pc.MusicAudioSource.clip = MusicClip;
            pc.MusicAudioSource.Play();
        }

    }
}
