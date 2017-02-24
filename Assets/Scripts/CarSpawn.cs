using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour {


    public GameObject car;
	public bool sendCarsLeft;
    public int spawnInterval = 100;
    // Use this for initialization
    void Start () {
		

    }
	
	// Update is called once per frame

	void spawnACar(){
		car.GetComponent<Car> ().goLeft = sendCarsLeft;
		Instantiate(car,transform.position, Quaternion.identity);
	}


	int spawnTimer = 0;

	void FixedUpdate () {
		spawnTimer++;

		if (spawnTimer > spawnInterval) {
			spawnACar ();
            // spawnTimer = Random.Range(0, 30);
            spawnTimer = 0;
		}

		
	}
}
