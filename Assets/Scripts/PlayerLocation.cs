using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocation : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start () {
        transform.position = player.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
