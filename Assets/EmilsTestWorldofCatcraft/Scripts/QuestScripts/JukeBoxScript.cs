using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JukeBoxScript : MonoBehaviour {

    private AudioSource source;
    public AudioClip jukeBoxClueSound;
    public AudioClip jukeBoxFullMusic;
    public static bool questComplete = false;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" & !source.isPlaying & questComplete == false)
        {
            source.PlayOneShot(jukeBoxClueSound);
        }
        if (other.gameObject.tag == "Player" & !source.isPlaying & questComplete == true)
        {
            source.PlayOneShot(jukeBoxFullMusic);
        }
    }
}
