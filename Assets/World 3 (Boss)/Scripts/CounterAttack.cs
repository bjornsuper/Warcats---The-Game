using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterAttack : MonoBehaviour {

    private GameObject go;

    public AudioClip counterAttackSound;

    private AudioSource source;

    public Transform boss;

    public float speed;

    private bool playerShot;

    public int damage = 9;

    // Use this for initialization
    void Start () {
        go = GameObject.Find("BossLocation");
        boss = go.transform;
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (BossAttributes.encounterStartet == true & playerShot == true)
        {
            float step = speed * Time.deltaTime;
 
            if (transform.position != boss.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, boss.position, step);
            }
            else
            {
                playerShot = false;

                if (BossAttributes.health <= damage) {
                    BossAttributes.isBossAlive = false;
                    //Debug.Log(" u won gz mate");
                }
                else{
                    BossAttributes.health = BossAttributes.health - damage;
                }
                //Debug.Log(BossAttributes.isBossAlive);
                //Debug.Log(BossAttributes.health);
                Destroy(gameObject);
            }
        }

        if (BossAttributes.encounterStartet == false)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player" || other.gameObject.tag == "Hands") & !source.isPlaying)
        {
            source.PlayOneShot(counterAttackSound);
            playerShot = true;
        }
    }
}
