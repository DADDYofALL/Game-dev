using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_controller : MonoBehaviour {

	public GameObject Player;
	private Vector3 offset;
	//float Hspeed = 2.0f;
	//float Vspeed = 2.0f;

	void Start () {
		offset = transform.position - Player.transform.position;
	}

	void LateUpdate () {
		transform.position = Player.transform.position + offset;
		/*float h = Hspeed * Input.GetAxis ("Mouse X");
		float v = Vspeed * Input.GetAxis ("Mouse Y");
		transform.Rotate (-v, h, 0);*/
	}
}
