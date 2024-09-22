using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomBall();
    }
    

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Spawn Interval for ball prefabs falling
        Invoke("SpawnRandomBall", Random.Range(3.0f, 5.0f)) ;
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Index for BallPrefabs
        int ballindex = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballindex], spawnPos, ballPrefabs[ballindex].transform.rotation);
    }

}
