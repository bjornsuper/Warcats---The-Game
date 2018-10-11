using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public static bool key1 = false;

    public static bool key2 = false;

    public GameObject door1;

    Scene currentScene;

    // Use this for initialization
    void Start () {
        currentScene = SceneManager.GetActiveScene();

        if (currentScene.name == "SampleScene") { 
            door1 = GameObject.FindGameObjectWithTag("Door1");
            door1.SetActive(false);
        }
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key1"))
        {
            other.gameObject.SetActive(false);
            key1 = true;
            checkKeys();
        }

        if (other.gameObject.CompareTag("Key2"))
        {
            other.gameObject.SetActive(false);
            key2 = true;
            checkKeys();
        }
    }

    private void checkKeys() {
        if (key1 == true & key2 == true)
        {
            door1.SetActive(true);
        }
    }

    //Wait for secound before method
    IEnumerator disableDoor() {
        yield return new WaitForSeconds(1);
        //Debug.Log("heheheh");
    }
}

    
