using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDead : MonoBehaviour {

    public float speed;

    public Transform target;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (BossAttributes.encounterStartetOnce == true & BossAttributes.encounterStartet == false)
        {
            //Debug.Log("he dead");
            MoveToPos1();
        }
    }

    private void MoveToPos1()
    {
        float step = speed * Time.deltaTime;

        if (transform.position != target.position)
        {
            //Debug.Log("he move");
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        else {
            gameObject.SetActive(false);
        }
    }
}
