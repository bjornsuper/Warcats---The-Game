using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {



    // Use this for initialization
    void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hands" & UI_Count.isqueststarted == true)
        {
            PickUpSound.soundPlayed = true;
            gameObject.SetActive(false);
        }
    }
}
