using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JukeBoxScript : MonoBehaviour {

    private AudioSource source;

    public AudioSource song2;
    public AudioClip jukeBoxClueSound;
    public AudioClip jukeBoxFullMusic;
    public static bool questComplete = false;
    public static bool jukeBoxCurrentlyPlaying;

    // Use this for initialization
    void Start () {
        jukeBoxCurrentlyPlaying = false;
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (questComplete == true & !source.isPlaying) {
            PartyTimeChecker.partytime = true;
            source.Play(0);
            //source.PlayOneShot(jukeBoxFullMusic);
        }
        if (!source.isPlaying & jukeBoxCurrentlyPlaying == true) {
            jukeBoxCurrentlyPlaying = false;
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" & !source.isPlaying & questComplete == false)
        {
            jukeBoxCurrentlyPlaying = true;
            source.PlayOneShot(jukeBoxClueSound);
        }
        /*
        if (other.gameObject.tag == "Player" & !source.isPlaying & questComplete == true)
        {
            PartyTimeChecker.partytime = true;
            source.PlayOneShot(jukeBoxFullMusic);
        }
        */
    }
}
