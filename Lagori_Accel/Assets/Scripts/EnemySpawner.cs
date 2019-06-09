using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyObject;
    public float secondsBetweenSpawn;
    private float elapsedTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime>secondsBetweenSpawn)
        {
            elapsedTime = 0;
            Vector3 spawnPosition = new Vector3(Random.Range(-10, 10), Random.Range(-6, 6), 0f);
            enemyObject = (GameObject)Instantiate(enemyObject, spawnPosition, Quaternion.identity);
            
           
        }
        
    }
}
