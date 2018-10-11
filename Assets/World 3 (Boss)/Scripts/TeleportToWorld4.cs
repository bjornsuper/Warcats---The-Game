using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToWorld4 : MonoBehaviour {

    public static bool amTeleporting = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        amTeleporting = true;
        StartCoroutine(teleportToWorld4());
        
    }

    IEnumerator teleportToWorld4()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(3);
    }
}
