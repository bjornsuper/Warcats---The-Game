using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingCitizenTalkTrigger : MonoBehaviour
{

    public AudioClip speach;
    public AudioClip speach2;
    private AudioSource source;
    private bool audioClip1Played = false;
    private bool audioClip2Played = false;
    private static bool key1;


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
        key1 = PlayerControllerTestWorld.key1;

        if (!source.isPlaying)
        {
            source.UnPause();
            //Debug.Log("its playing");
        }

        if (other.gameObject.tag == "Player" & audioClip1Played == false & !source.isPlaying)
        {
            audioClip1Played = true;
            source.PlayOneShot(speach);
        }
        else if (other.gameObject.tag == "Player" & audioClip2Played == false & !source.isPlaying & key1 == true)
        {
            audioClip2Played = true;
            source.PlayOneShot(speach2);
        }
        //Debug.Log("Entered");
    }

    void OnTriggerExit(Collider other)
    {
        if (source.isPlaying)
        {
            source.Pause();
        }
    }
}
