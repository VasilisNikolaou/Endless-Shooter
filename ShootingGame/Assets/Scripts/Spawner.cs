using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    public Transform[] spawnPoints;
    public float startTimeBtwSpawns;

    private float timeBtwSpawns;

    // Start is called before the first frame update
    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        
         if(timeBtwSpawns <= 0)
         {
            int randPos = Random.Range(0, spawnPoints.Length);

            Instantiate(enemy, spawnPoints[randPos].position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns; 

         } else {

            timeBtwSpawns -= Time.deltaTime;
         }
    }
}
