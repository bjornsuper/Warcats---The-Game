using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireBallScript : MonoBehaviour {

    public Transform player;

    public float speed;

    public float howLongBeforeItFindPlayerLocation = 2F;

    private Vector3 targetLocation;

    private bool gotPosition;

    private GameObject go;

    // Use this for initialization
    void Start () {
        go = GameObject.Find("PlayerBodyLocationTracker");
        player = go.transform;
        
        StartCoroutine(getPlayerLocation());
    }
	
	// Update is called once per frame
	void Update () {
        if (BossAttributes.encounterStartet == true & gotPosition == true)
        {
            float step = speed * Time.deltaTime;

            if (transform.position != targetLocation)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetLocation, step);
            }
            else {
                Destroy(gameObject);
            }
        }

        if (BossAttributes.encounterStartet == false) {
            Destroy(gameObject);
        }
    }

    IEnumerator getPlayerLocation()
    {
        yield return new WaitForSeconds(howLongBeforeItFindPlayerLocation);
        targetLocation = player.position;
        gotPosition = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
