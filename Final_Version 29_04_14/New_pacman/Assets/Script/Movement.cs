using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public KeyCode moveUp;
	public KeyCode moveDown;
	public KeyCode moveLeft;
	public KeyCode moveRight;

	public float speed = 2;

	public Sprite spriteUp, spriteDown, spriteLeft, spriteRight;
	private SpriteRenderer spriteRenderer;

	public int status = 1;

	public int score;

    Timer timerRef;

	// Use this for initialization
	void Start () {
        timerRef = GameObject.Find("Timer").GetComponent<Timer>();
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (moveUp)) { 
						rigidbody2D.velocity = new Vector2 (0, speed);
			spriteRenderer.sprite = spriteUp;
				} else if (Input.GetKey (moveDown)) {
						rigidbody2D.velocity = new Vector2 (0, speed * -1);
			spriteRenderer.sprite = spriteDown;
				} else if (Input.GetKey (moveLeft)) {
						rigidbody2D.velocity = new Vector2 (speed * -1, 0);
			spriteRenderer.sprite = spriteLeft;
				} else if (Input.GetKey (moveRight)) {
						rigidbody2D.velocity = new Vector2 (speed, 0);
			spriteRenderer.sprite = spriteRight;
				}
	}
    void OnCollisionStay2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Killer") {          
            timerRef.StartTimer();
            StartCoroutine(startUpdateStatus(collider));
            Destroy(collider.gameObject);
        }
    }
    
    IEnumerator startUpdateStatus(Collision2D collider){
        while (GameObject.Find("Timer").GetComponent<Timer>().GetIsOn() == true)
        {
            status = 2;
            yield return new WaitForEndOfFrame();
        }
        status = 1;
    }
}
