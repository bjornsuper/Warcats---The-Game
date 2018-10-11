using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComplete : MonoBehaviour
{
    public AudioClip theKingsThanks;
    private AudioSource source;
    private bool clipPlayed;
    public static bool theKingTalkDone;

    // Use this for initialization
    void Start()
    {
        clipPlayed = false;
        theKingTalkDone = false;
        source = GetComponent<AudioSource>();
        StartCoroutine(getPlayerLocation());
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying & clipPlayed == true && theKingTalkDone == false) {
            theKingTalkDone = true;
        }
    }
    

    IEnumerator getPlayerLocation()
    {
        yield return new WaitForSeconds(3);
        source.PlayOneShot(theKingsThanks);
        clipPlayed = true;
    }
}
