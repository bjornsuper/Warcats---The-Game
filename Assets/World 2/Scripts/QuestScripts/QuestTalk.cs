using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTalk : MonoBehaviour
{

    private AudioSource source;
    public AudioClip givesQuest;
    public AudioClip questCompleate;
    private bool givesQuestPlayed = false;
    private bool saidThanks;

    // Use this for initialization
    void Start()
    {
        saidThanks = false;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" /*& givesQuestPlayed == false*/ & !source.isPlaying & !PartyTimeChecker.partytime)
        {
            source.PlayOneShot(givesQuest);
            givesQuestPlayed = true;
        }
        else if (other.gameObject.tag == "Player" & PartyTimeChecker.partytime & !source.isPlaying & saidThanks == false) {
            source.PlayOneShot(questCompleate);
            saidThanks = true;
        }
    }
}