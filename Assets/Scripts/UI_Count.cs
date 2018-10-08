using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Count : MonoBehaviour{

    public Text countText;
    public Text winText;
    public Text startText;

    private int gem;
    private int count;


    public bool Quest = false;
    public bool hasWon = false;

    private bool isqueststarted = false;
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

            startText.text = "Find the Crystals";
            Quest = true;
            isqueststarted = true;
            hasWon = true;
        }


        
        if (other.gameObject.CompareTag("Gem") & isqueststarted == true)
        {
            
            gem = gem+1;
            SetCountText();
            Debug.Log(gem);
            other.gameObject.SetActive(false);
        }
    

    }

    void SetCountText()
    {
        countText.text = "Items: " + gem.ToString();
        if (gem >= 6)
        {
            winText.text = "Quest Completed";
            startText.text = "";
        }
    }
}
