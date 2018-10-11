using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnteredCityCheck : MonoBehaviour {

    private AudioSource source;
    //public AudioClip cityMusic;
    public static bool castleEntered;


    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (castleEntered == true & !source.isPlaying)
        {
            //source.PlayOneShot(cityMusic);
            source.Play(0);
        }
    }
}
