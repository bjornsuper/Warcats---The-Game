using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivatePortal : MonoBehaviour {

    Scene currentScene;
    public static GameObject Portal;
    public static GameObject PortalColider;

    // Use this for initialization
    void Start () {
        currentScene = SceneManager.GetActiveScene();

        if (currentScene.name == "World 1")
        {
            Portal = GameObject.FindGameObjectWithTag("Portal");
            Portal.SetActive(false);
            PortalColider = GameObject.FindGameObjectWithTag("PortalColider");
            PortalColider.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void activatePortal() {
        Portal.SetActive(true);
        PortalColider.SetActive(true);
    }
}
