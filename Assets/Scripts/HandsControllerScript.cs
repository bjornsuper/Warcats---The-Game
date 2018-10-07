using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsControllerScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        /*
        if (other.gameObject.CompareTag("Gem"))
        {
            Quests.gems = Quests.gems + 1;
            other.gameObject.SetActive(false);
        }
        */
    }
}
