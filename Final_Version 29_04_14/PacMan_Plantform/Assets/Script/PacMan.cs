﻿using UnityEngine;
using System.Collections;

public class PacMan : MonoBehaviour {
	public int moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		 		if (Input.GetKey(KeyCode.A))
		if (Input.GetKey(KeyCode.W))
			rigidbody.AddForce(0,0,-1);
		
		if (Input.GetKey(KeyCode.S))
			rigidbody.AddForce(0,0,-1);

		if (Input.GetKey(KeyCode.A))
			rigidbody.AddForce(-1,0,0);
		
		if (Input.GetKey(KeyCode.D))
			rigidbody.AddForce(1,0,0);
	}
}
