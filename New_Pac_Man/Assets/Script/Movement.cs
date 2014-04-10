using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	int speed = 5;
	private Vector2 direction;

	// Use this for initialization
	void Start () {

		direction = new Vector2(10,10);
	
			

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			rigidbody2D.velocity = direction;
			//rigidbody2D.velocity.y = y;
		}
	}
}
