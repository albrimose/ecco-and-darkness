using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;


    public AudioSource MusicAudioSource;
    private Rigidbody2D rb;
    public GameObject EchoLight;
	public AudioSource audio;
	public AudioClip EchoSound;
	public AudioClip[] SwimSounds;
	public AudioClip[] FastSwimSounds;
    public float EchoSpeed = 20f;
    public float DashSpeed = 600f;
    public float DashCooldown = 2f;
    protected float DashTimeTil = 0f;
    public float EchoRetract = 5f;
    public float MaxEcho = 20f;
    public Vector3 SavedPosition;

    void Awake()
    {

        CheckPointManager.Instance.onRestore += OnRestore;
        CheckPointManager.Instance.onCheckPoint += OnCheckpoint;
    }

    void OnRestore()
    {
        transform.position = SavedPosition;
        rb.velocity = Vector3.zero;
    }
    void OnCheckpoint()
    {
        SavedPosition = transform.position;
    }

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        SavedPosition = transform.position;
    }
	
    //public void Death()
    //{
    //    if(onDeath != null)
    //    {
    //        onDeath.Invoke();
    //    }
    //}

	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);
		if (Input.GetButton ("Dash") && DashTimeTil <= 0f) {
			DashTimeTil = DashCooldown;
			rb.AddForce (movement * DashSpeed * Time.deltaTime, ForceMode2D.Impulse);

			if (!audio.isPlaying) 
			{
				audio.clip = FastSwimSounds [Random.Range (0, FastSwimSounds.Length)];
				audio.Play ();
			}
		} 
		else if (moveHorizontal != 0f || moveVertical != 0f)
		{
			if (!audio.isPlaying) 
			{
				audio.clip = SwimSounds [Random.Range (0, SwimSounds.Length)];
				audio.Play ();
			}
		}
        
        if(DashTimeTil > 0f)
        {
            //Debug.Log(DashTimeTil);
            DashTimeTil -= Time.deltaTime;
        }
        rb.AddForce(movement * speed * Time.deltaTime);
        

        if(EchoLight != null)
        {
            if(Input.GetButtonDown("Echo"))
            {
				audio.clip = EchoSound;
				audio.Play();
            }
			if(Input.GetButtonUp("Echo"))
			{
				//audio.Stop();
			}
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
