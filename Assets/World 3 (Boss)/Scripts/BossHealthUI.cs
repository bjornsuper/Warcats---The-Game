using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthUI : MonoBehaviour {

    public Text bossHealth;

    // Use this for initialization
    void Start()
    {
        bossHealth.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        SetCountText();
    }

    void SetCountText()
    {
        if (BossAttributes.isBossAlive) {
            bossHealth.text = "Boss Health: " + BossAttributes.health.ToString();
        }
        else if (!BossAttributes.isBossAlive) {
            bossHealth.text = "Boss Health: 0";
        }
    }
}
