using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleMusic : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            EnteredCityCheck.castleEntered = true;
            gameObject.SetActive(false);
        }
    }
}
