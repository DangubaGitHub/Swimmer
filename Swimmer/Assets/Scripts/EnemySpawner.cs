using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject[] enemyPrefabs;

    [SerializeField] float timeBetweenSpawns;
    float nextSpawnTime;


    void Start()
    {
        
    }

    void Update()
    {
        

        if(Time.time > nextSpawnTime)
        {
            SpawnEnemie();

            nextSpawnTime = Time.time + timeBetweenSpawns;
        }
    }

    void SpawnEnemie()
    {
        int randEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
    }
}
