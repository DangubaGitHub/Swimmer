using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject[] enemyPrefabs;

    public float timeBetweenSpawns;
    float nextSpawnTime;


    void Start()
    {
        timeBetweenSpawns = 5f;
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
