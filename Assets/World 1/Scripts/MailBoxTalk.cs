using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailBoxTalk : MonoBehaviour {

    private AudioSource source;
    public AudioClip questDialogue;


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
        if (other.gameObject.tag == "Player" & !source.isPlaying)
        {
            source.PlayOneShot(questDialogue);
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
