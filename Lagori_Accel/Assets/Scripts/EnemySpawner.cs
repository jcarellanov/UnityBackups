using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyObject;
    public GameObject ballObject;
    public float secondsBetweenSpawn;
    public float secondsBetweenSpawnBalls;
    private float elapsedTime = 0.0f;
    private float elapsedBallTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-10, 10), Random.Range(-5, 5), 0f);
        GameObject ballObjectCopy = (GameObject)Instantiate(ballObject, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        elapsedBallTime += Time.deltaTime;

        if(elapsedTime>secondsBetweenSpawn)
        {
            elapsedTime = 0;
            Vector3 spawnPosition = new Vector3(Random.Range(-10, 10), Random.Range(-6, 6), 0f);
           GameObject enemyObjectCopy = (GameObject)Instantiate(enemyObject, spawnPosition, Quaternion.identity);
            
           
        }

        if (elapsedBallTime > secondsBetweenSpawnBalls)
        {
            elapsedBallTime = 0;
            Vector3 spawnPosition = new Vector3(Random.Range(-10, 10), Random.Range(-5, 5), 0f);
          GameObject  ballObjectCopy = (GameObject)Instantiate(ballObject, spawnPosition, Quaternion.identity);


        }


    }
}
