using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour {

    public static bool fragment1;
    public static bool fragment2;
    public static bool fragment3;
    public static bool fragment4;

    public static bool fragment1Taken;
    public static bool fragment2Taken;
    public static bool fragment3Taken;
    public static bool fragment4Taken;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public static void fragmentCheck() {
        /*
        Debug.Log(fragment1);
        Debug.Log(fragment2);
        Debug.Log(fragment3);

        
        if (fragment1 == true)
        {
            if (fragment2 == true)
            {
                if (fragment3 == true)
                {
                    Debug.Log("Que Cool music");
                }
            }
            else
            {

            }
        }
        else
        {

        }
        */
        if (fragment1 == true & fragment2 == true & fragment3 == true & fragment4 == true & fragment4Taken == true) {
            //Debug.Log("4 fragments");
            JukeBoxScript.questComplete = true;
            Fragment1Controller.disableFragment1();
            Fragment2Controller.disableFragment2();
            Fragment3Controller.disableFragment3();
            Fragment4Controller.disableFragment4();
        }
        else if (fragment1 == true & fragment2 == true & fragment3 == true & fragment4 == false & fragment3Taken == true)
        {
            //Debug.Log("3 fragments");
        }
        else if (fragment1 == true & fragment2 == true & fragment3 == false & fragment4 == false & fragment2Taken == true)
        {
            //Debug.Log("2 fragments");
        }
        else if (fragment1 == true & fragment2 == false & fragment3 == false & fragment4 == false & fragment1Taken == true)
        {
            //Debug.Log("1 fragments");
        }
        else
        {
            fragment1 = false;
            fragment2 = false;
            fragment3 = false;
            fragment4 = false;
            //Debug.Log("all wrong");
        }


    }
}
