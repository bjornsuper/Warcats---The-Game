using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragment4Controller : MonoBehaviour {

    public static GameObject fragment4;

    // Use this for initialization
    void Start()
    {
        fragment4 = GameObject.FindGameObjectWithTag("Fragment4");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        QuestController.fragment4 = true;
        QuestController.fragment1Taken = false;
        QuestController.fragment2Taken = false;
        QuestController.fragment3Taken = false;
        QuestController.fragment4Taken = true;
        QuestController.fragmentCheck();
    }

    public static void disableFragment4()
    {
        fragment4.SetActive(false);
    }
}
