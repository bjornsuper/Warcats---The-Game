using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPillarEvent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player" || other.gameObject.tag == "Hands") & PartyTimeChecker.partytime == true)
        {
            Pillar1Controller.movePillarEvent = true;
        }
    }
}
