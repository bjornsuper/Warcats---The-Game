using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar11Controller : MonoBehaviour {

    public float speed;
    public Transform target;
    public static bool pillarInPosition;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Pillar10Controller.pillarInPosition)
        {
            MovePillar();
        }
    }

    private void MovePillar()
    {
        float step = speed * Time.deltaTime;

        if (transform.position != target.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        else if (transform.position == target.position)
        {
            pillarInPosition = true;
        }
    }
}
