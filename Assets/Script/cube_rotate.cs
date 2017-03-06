using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_rotate : MonoBehaviour {

	private float st;

	void Start (){
		st = Time.time;	
	}

	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
		if (Time.time - st > 5){
			Destroy (this.gameObject);
		}
	}
}
