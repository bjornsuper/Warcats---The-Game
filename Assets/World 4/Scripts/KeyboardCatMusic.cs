using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardCatMusic : MonoBehaviour {

    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameComplete.theKingTalkDone == true & !source.isPlaying)
        {
            source.Play(0);
        }
    }
}
