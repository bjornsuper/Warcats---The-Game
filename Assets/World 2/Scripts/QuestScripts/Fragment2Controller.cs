using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragment2Controller : MonoBehaviour {

    public static GameObject fragment2;

    // Use this for initialization
    void Start(){
        fragment2 = GameObject.FindGameObjectWithTag("Fragment2");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        QuestController.fragment2 = true;
        QuestController.fragment1Taken = false;
        QuestController.fragment2Taken = true;
        QuestController.fragment3Taken = false;
        QuestController.fragment4Taken = false;
        QuestController.fragmentCheck();
    }

    public static void disableFragment2()
    {
        fragment2.SetActive(false);
    }
}
