using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTalk : MonoBehaviour
{

    private AudioSource source;
    public AudioClip givesQuest;
    private bool givesQuestPlayed = false;

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
        if (other.gameObject.tag == "Player" & givesQuestPlayed == false & !source.isPlaying)
        {
            source.PlayOneShot(givesQuest);
            givesQuestPlayed = true;
        }
    }
}