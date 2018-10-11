using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoss : MonoBehaviour {

    public Transform target;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     /*
        Vector3 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        transform.rotation = rotation;
    

    */
    if (target != null & BossAttributes.encounterStartet == true)
    {
        transform.LookAt(target);
    }
    
}
}
