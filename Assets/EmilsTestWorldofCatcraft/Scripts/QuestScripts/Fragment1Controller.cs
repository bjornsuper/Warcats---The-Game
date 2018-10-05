using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragment1Controller : MonoBehaviour {


    public static GameObject fragment1;
    // Use this for initialization
    void Start(){
        fragment1 = GameObject.FindGameObjectWithTag("Fragment1");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        QuestController.fragment1 = true;
        QuestController.fragment1Taken = true;
        QuestController.fragment2Taken = false;
        QuestController.fragment3Taken = false;
        QuestController.fragment4Taken = false;
        QuestController.fragmentCheck();
    }

    public static void disableFragment1() {
        fragment1.SetActive(false);
    }
}
