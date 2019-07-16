using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject [] obstaclePatern;

    private float timeBtwSpawn;
    public float startTitmeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
   
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatern.Length);
            Instantiate(obstaclePatern[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTitmeBtwSpawn;
            if (startTitmeBtwSpawn > minTime)
            {
                startTitmeBtwSpawn -= decreaseTime;
            }

        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }

    }
}
