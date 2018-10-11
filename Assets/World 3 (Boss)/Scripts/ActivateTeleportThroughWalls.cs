using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateTeleportThroughWalls : MonoBehaviour {

    public static GameObject Walls;

    // Use this for initialization
    void Start () {
        Walls = GameObject.FindGameObjectWithTag("NoTPWalls");
        Walls.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void activateWalls()
    {
        Walls.SetActive(true);
    }
}
