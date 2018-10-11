using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyTimeChecker : MonoBehaviour {

    public static bool partytime;
    private GameObject partyDragon;
    private GameObject partyGuests;

    // Use this for initialization
    void Start () {
        partytime = false;
        partyDragon = GameObject.FindGameObjectWithTag("PartyDragon");
        partyDragon.SetActive(false);
        partyGuests = GameObject.FindGameObjectWithTag("PartyGuests");
        partyGuests.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (partytime) {
            partyDragon.SetActive(true);
            partyGuests.SetActive(true);
        }
	}
}
