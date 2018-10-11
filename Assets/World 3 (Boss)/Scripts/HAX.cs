using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HAX : MonoBehaviour {

    public AudioClip haxActivateAnnouncement;
    private AudioSource source;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Hands")
        {
            BossAttributes.isBossAlive = false;
            if (!source.isPlaying)
            {
                source.PlayOneShot(haxActivateAnnouncement);
            }
        }
    }
}
