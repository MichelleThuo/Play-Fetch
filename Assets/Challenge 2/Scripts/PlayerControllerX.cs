using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timer;
    private float timeLimit = 1.0f;

    // Update is called once per frame
    void Update()
    {
        //Create timer
        timer += Time.deltaTime;
        // On spacebar press, send dog and timer is greater than the time limit
        if (Input.GetKeyDown(KeyCode.Space)&& timer > timeLimit)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //Reset timer
            timer = 0;
        }
    }
}
