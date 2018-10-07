using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSound : MonoBehaviour {

    private AudioSource source;
    public AudioClip pickUpSound;
    public static bool soundPlayed;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

        if (soundPlayed == true) { 
            PlaySound();
        }
    }

    public void PlaySound() {
        source.PlayOneShot(pickUpSound);
        soundPlayed = false;
    }
}
