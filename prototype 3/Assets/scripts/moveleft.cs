﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveleft : MonoBehaviour
{
    private float speed = 30;
    private float leftBound = -15;
    private PlayerController PlayerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControllerScript.gameOver == false){
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x <leftBound && GameObject.CompareTag("Obstacle")){
            Destroy(GameObject);
        }
    }
}
