﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //movement
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			transform.Translate (0, 1, 0);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			transform.Translate (0, -1, 0);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.Translate (1, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.Translate (-1, 0, 0);
		}
		
	}
}
