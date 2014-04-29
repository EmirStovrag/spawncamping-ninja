using UnityEngine;
using System.Collections;

public class Maze_Builder : MonoBehaviour {

	public Transform Crate;	// This variable holds the Prefab you add to the script in Unity
	public Transform Point;

	private const int xSize = 20; 
	private const int zSize = 16;

	public int[,] bluePrint = new int[zSize,xSize]			// This array controls the maze
	{	{ 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
		{ 1,2,2,2,2,2,2,1,2,2,2,2,2,2,1,2,2,2,2,1 },
		{ 1,2,1,1,1,1,2,1,2,1,1,1,1,2,1,2,1,1,2,1 },
		{ 1,2,1,2,2,2,2,1,2,1,2,1,2,2,1,2,1,1,2,1 },
		{ 1,2,1,2,1,2,2,2,2,2,2,2,2,2,2,2,2,1,2,1 },
		{ 1,2,1,2,1,2,1,1,1,1,1,1,2,2,2,1,2,2,2,1 },
		{ 1,2,1,2,1,2,2,2,2,2,2,2,2,1,1,1,2,1,2,1 },
		{ 1,2,2,2,1,2,1,0,1,1,0,1,2,2,2,2,2,1,2,1 },
		{ 1,2,1,2,1,2,1,0,0,0,0,1,2,1,2,1,1,1,2,1 },
		{ 1,2,1,2,1,2,1,0,0,0,0,1,2,2,2,2,2,2,2,1 },
		{ 1,2,1,2,1,2,1,1,1,1,1,1,2,1,1,1,1,1,2,1 },
		{ 1,2,1,2,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1 },
		{ 1,2,1,2,2,2,2,1,2,1,1,1,1,2,1,2,2,1,2,1 },
		{ 1,2,1,1,1,1,2,1,2,1,1,1,1,2,1,2,1,1,2,1 },
		{ 1,2,2,2,2,2,2,1,2,2,2,2,2,2,1,2,2,2,2,1 },
		{ 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
	};

	void Start () {

		GameObject[,] maze = new GameObject[zSize,xSize];
		for (int z=0 ; z<zSize ; z++){
			for (int x=0 ; x<xSize ; x++){
				if(bluePrint[z,x] == 1)
					maze[z,x] = Instantiate(Crate, new Vector2(x*2.0f-xSize+1,/* 0.0f,*/ -z*2.0f+zSize-1), Quaternion.identity) as GameObject;
				if (bluePrint [z, x] == 2) {
					maze[z,x] = Instantiate(Point, new Vector2(x*2.0f-xSize+1,/* 0.0f,*/ -z*2.0f+zSize-1), Quaternion.identity) as GameObject;

				}
					//creating a scoreObject

			
			
			}
		}
	}

	// Update is called once per frame
	void Update () 
	{

	}
}
