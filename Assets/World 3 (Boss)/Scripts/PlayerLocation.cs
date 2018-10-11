using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocation : MonoBehaviour {

    public Transform player;

    public Transform jumpPuzzleReset;

    public static bool failedJumpPuzzle;
    // Use this for initialization
    void Start () {
        transform.position = player.position;
        failedJumpPuzzle = false;

    }
	
	// Update is called once per frame
	void Update () {
        if (jumpPuzzleReset != null & failedJumpPuzzle == true) {
            transform.position = jumpPuzzleReset.position;
            failedJumpPuzzle = false;
        }
    }  
}
