using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossYell : MonoBehaviour {

    public AudioClip bossYell;
    private AudioSource source;
    private static bool clipPlayed;
    private static bool created = false;
    Scene currentScene;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
        //StartCoroutine(getPlayerLocation());
    }

    private void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
    }



    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene();
        if (BossAttributes.encounterStartet == true & clipPlayed == false) {
            source.PlayOneShot(bossYell);
            clipPlayed = true;
        }

        if (currentScene.name != "World 3 (Boss)")
        {
            Destroy(gameObject);
        }
    }

    /*
    IEnumerator getPlayerLocation()
    {
        yield return new WaitForSeconds(3);
        source.PlayOneShot(bossYell);
        clipPlayed = true;
    }
    */
}
