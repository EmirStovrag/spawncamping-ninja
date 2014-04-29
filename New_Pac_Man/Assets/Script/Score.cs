using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public int finalScore = 1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        finalScore = GameObject.Find("Pacman").GetComponent<Movement>().score;
        guiText.text = "Score " + finalScore;
	}
}
