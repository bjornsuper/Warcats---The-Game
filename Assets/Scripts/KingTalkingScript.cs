using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingTalkingScript : MonoBehaviour {

    public AudioClip theKingsQuest;
    public AudioClip theKingsReward;
    private AudioSource source;
    private bool audioClip1Played = false;
    private bool audioClip2Played = false;
    private static int gems;


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
        gems = Quests.gems;

        if (!source.isPlaying)
        {
            source.UnPause();
            //Debug.Log("its playing");
        }

        if (other.gameObject.tag == "Player" & audioClip1Played == false & !source.isPlaying)
        {
            audioClip1Played = true;
            source.PlayOneShot(theKingsQuest);
        }
        else if (other.gameObject.tag == "Player" & audioClip2Played == false & !source.isPlaying & gems >= 3)
        {
            audioClip2Played = true;
            source.PlayOneShot(theKingsReward);
            ActivatePortal.activatePortal();
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
