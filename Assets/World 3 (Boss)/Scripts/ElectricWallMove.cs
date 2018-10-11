using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElectricWallMove : MonoBehaviour
{
    public float speed;

    public Transform target;
    public Transform target2;

    private bool target1Reached;
    private bool target2Reached;

    private bool aTargetMet;
    private bool bTargetMet;


    // Use this for initialization
    void Start()
    {
        aTargetMet = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (BossAttributes.encounterStartet == true) {

            if (aTargetMet == true) {
                MoveToPos2();
            }
            else if (bTargetMet == true)
            {
                MoveToPos1();
            }

        }

        if (BossAttributes.encounterStartet == false & BossAttributes.encounterStartetOnce == true)
        {
            gameObject.SetActive(false);
        }
    }

    private void MoveToPos1()
    {
        float step = speed * Time.deltaTime;

        if (transform.position != target.position & aTargetMet == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        else {
            aTargetMet = true;
            bTargetMet = false;
        }
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
            aTargetMet = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
