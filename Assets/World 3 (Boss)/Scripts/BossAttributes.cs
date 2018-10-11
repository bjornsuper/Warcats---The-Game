using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttributes : MonoBehaviour {

    public static int health;
    public static bool isBossAlive;
    public static bool encounterStartet;
    public static bool encounterStartetOnce;

    // Use this for initialization
    void Start () {
        health = 100;
        isBossAlive = true;
        encounterStartet = false;
        encounterStartetOnce = false;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(health);
        //Debug.Log(isBossAlive);
    }
}
