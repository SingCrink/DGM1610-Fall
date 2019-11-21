using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
        public GameObject[] enemyPrefabs;



    void Start()
    {
        
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(enemyPrefabs[0], new Vector3(2, 0, 0), enemyPrefabs[0].transform.rotation);


        }
    }





















}
