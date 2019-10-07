﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }
 private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    void Update() {
        if (Input.GetKeyDown(KeyCode.S)) {
            // randomly generate animal index and spawn position
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            0, spawnPosZ);
            int animalIndex = Random.Range(0,animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation); }}
            
}