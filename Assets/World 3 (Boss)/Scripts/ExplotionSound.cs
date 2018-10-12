using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplotionSound : MonoBehaviour {

    public AudioClip explotionSound;
    private AudioSource source;
    public static bool hasExploded = false;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (hasExploded) {
            hasExploded = false;
            source.PlayOneShot(explotionSound);
        }
	}
}
