using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

	//go left or go right!
	public bool goLeft= false;

	//movement speed
	float speed = 4;


	void Start () {
		//choose speed depending on direction!
		if (goLeft==true) {
			speed = -4;
		}
		if (goLeft==false) {
			speed = 4;
		}
	}

  


    // Update is called once per frame
    void FixedUpdate () {


		// movement of the car
		transform.Translate (speed*Time.deltaTime, 0, 0);


		// logic for removing the car
		if (goLeft == true) {
			if (transform.position.x < -12) {
				Destroy (gameObject);
			}
		}

		if (goLeft == false) {
			if (transform.position.x > 12) {
				Destroy (gameObject);
			}
		}


	}


    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Frogger>().enabled = false;
        other.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1, 1, 1, .3f);
        //Destroy(other.gameObject);
    }
}
