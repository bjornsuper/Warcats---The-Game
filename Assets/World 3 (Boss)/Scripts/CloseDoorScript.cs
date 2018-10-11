using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoorScript : MonoBehaviour {

    public Transform target;

    public float speed;

    private bool targetMet;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (targetMet == false & BossAttributes.encounterStartet == true) {
            MoveToPos1();
        }
	}

    private void MoveToPos1()
    {
        float step = speed * Time.deltaTime;

        if (transform.position != target.position & targetMet == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        else
        {
            targetMet = true;
        }
    }
}
