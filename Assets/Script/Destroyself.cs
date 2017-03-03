using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyself : MonoBehaviour {

	private float st;

	void Start (){
		st = Time.time;	
	}

	void Update () {
		if (Time.time - st > 15){
			Destroy (this.gameObject);
		}
	}
}
