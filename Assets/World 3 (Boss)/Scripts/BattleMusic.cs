using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleMusic : MonoBehaviour {

    private AudioSource source;
    //private AudioClip battleMusic;
    public static bool arenaEntered;

    private static bool created = false;
    private static bool playing = false;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void Awake()
    {
        if (!created) {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (arenaEntered == true & !source.isPlaying & playing == false)
        {
            //source.PlayOneShot(battleMusic);
            source.Play(0);
            playing = true;
        }


        /*
        if (Input.GetKeyDown("space")) {
            //Debug.Log("loll");
            //SceneManager.LoadScene(1);
            source.Stop();
        }
        */
        if (TeleportToWorld4.amTeleporting == true)
        {
            source.Stop();
        }
    }
}
