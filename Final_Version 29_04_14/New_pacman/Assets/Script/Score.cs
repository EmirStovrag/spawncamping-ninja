using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public int PlayerHitPoints = 3;
	public GUIText PlayerHealth;

	// Use this for initialization
	void Start () {
		PlayerHealth.text = "Health left: " + PlayerHitPoints.ToString();
	}
	
	// Update is called once per frame
	void UpdateText ()
	{
		PlayerHealth.text = "Health left: " + PlayerHitPoints;
		if (PlayerHitPoints <= 0)
		{
			Time.timeScale = 0;
		}
		deductHP ();
	}

	void deductHP(){
		PlayerHitPoints--; 
		UpdateText ();
	}
}
