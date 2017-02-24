using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour {

    // Use this for initialization
    GameObject player;

	void Start () {

        player = GameObject.Find("frog");
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //transform.position.y = player.transform.position.y;
       // transform.position.x = new Mathf.Lerp(transform.position.x, player.transform.x, 5.0f * Time.deltaTime);
        transform.position = new Vector3(0, Mathf.Lerp(transform.position.y,3f+ player.transform.position.y, Time.deltaTime * 3f), 0);
    }
}
