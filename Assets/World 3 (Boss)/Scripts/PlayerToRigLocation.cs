using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerToRigLocation : MonoBehaviour {

    public Transform steamVRRig;
    public Transform simulationRig;
    public Transform oculusRig;
    public Transform windowsMRRig;
    public Transform unityXRRig;

    public GameObject steamVRObj;
    public GameObject simulationrigObj;
    public GameObject oculusObj;
    public GameObject windowsMRObj;
    public GameObject unityXRObj;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (steamVRObj.activeInHierarchy == true) {
            transform.position = steamVRRig.position;
        }
        else if (simulationrigObj.activeInHierarchy == true) {
            transform.position = simulationRig.position;
        }
        else if (oculusObj.activeInHierarchy == true)
        {
            transform.position = oculusRig.position;
        }
        else if (windowsMRObj.activeInHierarchy == true)
        {
            transform.position = windowsMRRig.position;
        }
        else if (unityXRObj.activeInHierarchy == true)
        {
            transform.position = unityXRRig.position;
        }
    }
}