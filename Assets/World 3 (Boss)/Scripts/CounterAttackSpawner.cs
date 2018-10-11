using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterAttackSpawner : MonoBehaviour {

    public GameObject prefab;
    public float howLongTilSpawn = 5F;

    public static bool startSpawning;

    private bool spawnIsReady = true;

    //List for where the prefab can spawn on map
    List<int> numbersToChooseFrom = new List<int>(new int[]
    { -4, -5, -6, -7, -8, -9, -10, -11, -12, -13, -14, -15, -16, -17, -18, -19, -20, -21, -22, -23, -24,
        4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24});

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        if (BossAttributes.encounterStartet == true & spawnIsReady == true) {
            StartCoroutine(SpawnTimer());
        }
	}

    IEnumerator SpawnTimer()
    {

        spawnIsReady = false;
        yield return new WaitForSeconds(howLongTilSpawn);
        Spawn();
        spawnIsReady = true;
    }

    void Spawn()
    {
        int randomNumberX = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
        int randomNumberZ = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];

        /* 
         * Old Random Spawn Script (I can spawn in the boss)
        float randomX = Random.Range(-24f, 24f);
        float randomZ = Random.Range(-24f, 24f);

        
        Instantiate(prefab, new Vector3(randomX, 1f, randomZ), Quaternion.identity);
        */
        Instantiate(prefab, new Vector3(randomNumberX, 1f, randomNumberZ), Quaternion.identity);
        
    }
}
