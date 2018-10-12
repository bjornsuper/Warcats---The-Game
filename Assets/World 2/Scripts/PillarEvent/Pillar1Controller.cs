using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar1Controller : MonoBehaviour {

    public static bool movePillarEvent;
    public float speed;
    public Transform target;
    public static bool pillarInPosition;

    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (movePillarEvent)
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
        else if (transform.position == target.position) {
            pillarInPosition = true;
        }
    }
}
