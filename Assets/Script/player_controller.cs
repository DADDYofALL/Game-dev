﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {

	private Rigidbody rb;
	private Vector3 jump = new Vector3(0.0f,1.0f,0.0f);
	void Start () {
		rb = GetComponent <Rigidbody> ();
	}

	void FixedUpdate(){
		float mH = Input.GetAxis ("Horizontal");
		//float mV = Input.GetAxis ("Vertical");
		Vector3 move = new Vector3 (mH, 0.0f, 0.0f);
		if (Input.GetKeyDown("space") && transform.position.y < 0.6) {
			rb.AddForce (jump*500);
		}
		rb.AddForce (move * 50);
		transform.Translate(Vector3.forward * Time.deltaTime * 10f);
	}
}
