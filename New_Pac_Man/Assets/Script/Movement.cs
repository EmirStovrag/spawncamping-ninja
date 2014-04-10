using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	int speed = 5;
	private Vector2 directionUp;
	private Vector2 directonDown;
	private Vector2 directonLeft;
	private Vector2 directonRight;

	// Use this for initialization
	void Start () {

		directionUp = new Vector2 (10,10);
		directionDown = new Vector2 (-10, -10);
		directionLeft = new Vector2 (10,0);
		directionRight = new Vector2 (-10, 0);
	}

	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			rigidbody2D.velocity = directionUp;
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			rigidbody2D.velocity = directionDown;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rigidbody2D.velocity = directionLeft;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			rigidbody2D.velocity = directionRight;
		}
	}
}
