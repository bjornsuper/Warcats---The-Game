using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBoss : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ActivateTeleportThroughWalls.activateWalls();
            BossAttributes.encounterStartet = true;
            BossAttributes.encounterStartetOnce = true;
            BattleMusic.arenaEntered = true;
            gameObject.SetActive(false);
        }
    }
}
