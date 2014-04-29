using UnityEngine;
using System.Collections;

public class Ghost : MonoBehaviour {

	public float speed = 2;
	public int PlayerHitPoints = 2;
	public GUIText PlayerHealth;
	public Sprite spriteDeath, spriteAlive;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
	int randomNumber = Random.Range (1, 1);
		if (randomNumber == 1)
		{
			rigidbody2D.velocity = new Vector2 (0, speed);
		}
		PlayerHealth.text = "Health left: " + PlayerHitPoints.ToString();
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {

		/*if (Input.GetKey (KeyCode.A))
		{
		int x = Mathf.FloorToInt((transform.position.x + 10) /2);
		int z = Mathf.FloorToInt((transform.position.z + 8) /2);
		NumberOfExits (z,x);
		}*/
		if(GameObject.Find("Player").GetComponent<Movement>().status == 2)
			spriteRenderer.sprite = spriteDeath;
		else
			spriteRenderer.sprite = spriteAlive;
	

	}

	void OnCollisionStay2D(Collision2D collider)
	{
		if (collider.gameObject.tag == "Crate") 
		{
			int randomNumber = Random.Range (1, 5);
			if (randomNumber == 1) 
				rigidbody2D.velocity = new Vector2 (0, speed);
			else if (randomNumber == 2)
				rigidbody2D.velocity = new Vector2 (0, speed*-1);
			else if (randomNumber == 3)
				rigidbody2D.velocity = new Vector2 (speed*-1,0);
			else if (randomNumber == 4)
				rigidbody2D.velocity = new Vector2 (speed,0);

		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "Player" ){
			Destroy(other.gameObject);
			deductHP ();
		}
		Debug.Log ("Dead");
	}
	void UpdateText () {
		PlayerHealth.text = "Health left: " + PlayerHitPoints;
		if (PlayerHitPoints <= 0) {
			Time.timeScale = 0;
		}
	}

	void deductHP(){
		PlayerHitPoints--; // reduces hp by 1
		UpdateText ();
	}

	/*void NumberOfExits (int z, int x )
	{
		GameObject P = GameObject.FindGameObjectWithTag ("Platform");
		Maze_Builder S = P.GetComponent ("Maze_Builder") as Maze_Builder;
		//S.bluePrint;

		Debug.Log (S.bluePrint[z,x]);

	}*/

}
