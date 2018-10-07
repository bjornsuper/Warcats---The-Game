using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{

    public Transform target;

    public Transform target2;

    public Transform target3;

    private bool target1Reached;

    private bool target2Reached;

    private bool target3Reached;

    public float speed;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float step = speed * Time.deltaTime;

        if (transform.position != target.position & target1Reached == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        else if (transform.position == target.position)
        {
            target1Reached = true;
            transform.position = Vector3.MoveTowards(transform.position, target2.position, step);
        }
        else if (transform.position != target2.position & target2Reached == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target2.position, step);
        }
        else if (transform.position == target2.position)
        {
            target2Reached = true;
            transform.position = Vector3.MoveTowards(transform.position, target3.position, step);
        }
        else if (transform.position != target3.position & target3Reached == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target3.position, step);
        }
        */

        if (Input.GetKeyDown(KeyCode.A))
        {
            a = true;
        }

        if (a == true)
        {
            MoveToPos1();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            b = true;
        }

        if (b == true)
        {
            MoveToPos2();
        }
    }
    private bool a;
    private bool b;

    private bool aTargetMet;
    private bool bTargetMet;

    private void MoveToPos1()
    {
        float step = speed * Time.deltaTime;

        if (transform.position != target.position & aTargetMet == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        else {
            aTargetMet = true;
        }

        /*
        while (transform.position != target.position) {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            
        }
        */
    }

    private void MoveToPos2()
    {
        float step = speed * Time.deltaTime;

        if (transform.position != target2.position & bTargetMet == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target2.position, step);
        }
        else {
            bTargetMet = true;
        }
    }
}
