using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank : MonoBehaviour {

    // Use this for initialization
    public bool goLeft = false;

    //movement speed
    float speed = 1;


    void Start()
    {
        //choose speed depending on direction!
        if (goLeft == true)
        {
            speed = -1;
        }
        if (goLeft == false)
        {
            speed = 1;
        }
    }
 
    void FixedUpdate()
    {
        // movement of the plank
        transform.Translate(speed * Time.deltaTime, 0, 0);

        // logic for removing the plank
        if (goLeft == true)
        {
            if (transform.position.x < -12)
            {
                Destroy(gameObject);
            }
        }

        if (goLeft == false)
        {
            if (transform.position.x > 12)
            {
                Destroy(gameObject);
            }
        }

    }
    void OnTriggerStay2D(Collider2D other)
    {


        other.transform.position = Vector3.Lerp(other.transform.position, transform.position, Time.deltaTime * 25f);
    }
}
