using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour {

    public GameObject prefab;

    private bool fireBallSpawned;

    public float spawnFireBallWait = 0.25F;

	// Use this for initialization
	void Start () {
        //prefab = Resources.Load("../Prefabs/FireBall.prefab") as GameObject;
	}
    
    // Update is called once per frame
    void Update () {
        if (BossAttributes.encounterStartet == true & fireBallSpawned == false) { 
        StartCoroutine(spawnFireBall());
            fireBallSpawned = true;
        }
    }

    IEnumerator spawnFireBall()
    {
        yield return new WaitForSeconds(spawnFireBallWait);

        GameObject fireball = Instantiate(prefab) as GameObject;
        fireball.transform.position = transform.position;
        fireBallSpawned = false;
    }
}
