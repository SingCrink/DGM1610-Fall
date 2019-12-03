using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
        public GameObject[] enemyPrefabs;
        public float spawntime;



    void Start()
    {
        StartCoroutine(Spawn());
    }


   

    IEnumerator Spawn()
    {
        while (true)
        {
            int enemiesindex = Random.Range(0, enemyPrefabs.Length);
            GameObject enemy = enemyPrefabs[enemiesindex];
            Instantiate(enemy, transform.position, transform.rotation);
            yield return new WaitForSeconds(spawntime);
        }
        


    }





















}
