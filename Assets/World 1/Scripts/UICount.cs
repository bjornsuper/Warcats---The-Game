using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICount : MonoBehaviour{

    public Text countText;
    public Text winText;
    public Text startText;

    private int gem;
    private int count;


    public bool Quest = false;
    public bool hasWon = false;

    public static bool isqueststarted = false;
    private bool questdone = false;
    private bool winDone = false;


    // Use this for initialization
    void Start()
    {
        countText.text = "";
        winText.text = "";
        startText.text = "";
        count = 0;
        SetCountText();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Quest") & hasWon == false)
        {

            startText.text = "Find 3 Gems, Gems not Fish !";
            Quest = true;
            isqueststarted = true;
            hasWon = true;
        }


        
        if (other.gameObject.CompareTag("Gem") & isqueststarted == true)
        {
            Quests.gems = Quests.gems + 1;
            SetCountText();
            other.gameObject.SetActive(false);
            //Debug.Log(Quests.gems);
        }
    

    }

    void SetCountText()
    {
        countText.text = "Gems: " + Quests.gems.ToString();
        if (Quests.gems >= 3)
        {
            winText.text = "Quest Completed";
            startText.text = "";
        }
    }
}
