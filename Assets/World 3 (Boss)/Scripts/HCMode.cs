using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HCMode : MonoBehaviour {

    public AudioClip hcModeActivateAnnouncement;
    private AudioSource source;
    public static bool hardcodeMode;
    private GameObject hardcoreGO;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        hardcodeMode = false;
        hardcoreGO = GameObject.FindGameObjectWithTag("HardcoreGO");
        hardcoreGO.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Hands")
        {
            hardcoreGO.SetActive(true);

            if (!source.isPlaying)
            {
                source.PlayOneShot(hcModeActivateAnnouncement);
            }
        }
    }
}
