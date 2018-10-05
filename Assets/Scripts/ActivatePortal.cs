using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivatePortal : MonoBehaviour {

    Scene currentScene;
    public static GameObject Portal;

    // Use this for initialization
    void Start () {
        currentScene = SceneManager.GetActiveScene();

        if (currentScene.name == "World1")
        {
            Portal = GameObject.FindGameObjectWithTag("Portal");
            Portal.SetActive(false);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void activatePortal() {
        Portal.SetActive(true);
    }
}
