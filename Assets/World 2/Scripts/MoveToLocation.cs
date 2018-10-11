using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLocation : MonoBehaviour {

    public float speed;

    public Transform target;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (PartyTimeChecker.partytime == true)
        {
            MoveToPos1();
        }
    }

    private void MoveToPos1()
    {
        float step = speed * Time.deltaTime;

        if (transform.position != target.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
}
