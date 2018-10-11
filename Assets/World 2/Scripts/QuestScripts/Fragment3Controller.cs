using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragment3Controller : MonoBehaviour {

    public static GameObject fragment3;

    // Use this for initialization
    void Start(){
        fragment3 = GameObject.FindGameObjectWithTag("Fragment3");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        QuestController.fragment3 = true;
        QuestController.fragment1Taken = false;
        QuestController.fragment2Taken = false;
        QuestController.fragment3Taken = true;
        QuestController.fragment4Taken = false;
        QuestController.fragmentCheck();
    }

    public static void disableFragment3()
    {
        fragment3.SetActive(false);
    }
}
