using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverSpawner : MonoBehaviour {


    public GameObject plank;
    public GameObject water;
    public bool goLeft;
    public int spawnInterval = 100;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame

    void spawnPlank()
    {
        plank.GetComponent<Plank>().goLeft = goLeft;
        Instantiate(plank, transform.position, Quaternion.identity);
    }
    void spawnWater()
    {
        water.GetComponent<Water>().goLeft = goLeft;
        Instantiate(water, transform.position, Quaternion.identity);
    }

    int spawnTimer = 0;
    int randomNum;
    void Update()
    {
        spawnTimer++;

        if (spawnTimer > spawnInterval)
        {
            randomNum = Random.Range(0, 2);
            if (randomNum == 0)
            {
                spawnWater();
            }
            if (randomNum == 1)
            {
                spawnPlank();
            }
            spawnTimer = 0;
        }


    }
}
