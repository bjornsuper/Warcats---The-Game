using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragment1Sound : MonoBehaviour {

    private AudioSource source;
    public AudioClip fragmentClip;
    

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player" || other.gameObject.tag == "Hands") & JukeBoxScript.jukeBoxCurrentlyPlaying == false & !source.isPlaying)
        {
            source.PlayOneShot(fragmentClip);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (source.isPlaying)
        {
            source.Stop();
        }
    }
}
