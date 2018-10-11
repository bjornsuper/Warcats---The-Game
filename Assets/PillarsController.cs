using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarsController : MonoBehaviour {

    public float speed;

    public Transform target;

    public float waitTime = 1F;

    // Use this for initialization
    void Start () {
        //StartCoroutine(raisePillar());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    /* TO DO
    IEnumerator raisePillar()
    {
        yield return new WaitForSeconds(waitTime);
        targetLocation = player.position;
        gotPosition = true;
    }
    */
}
