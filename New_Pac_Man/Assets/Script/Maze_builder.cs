using UnityEngine;
using System.Collections;

public class Maze_builder : MonoBehaviour {
	
	public Transform Crate;								// This variable holds the Prefab you add to the script in Unity


	private const int xSize = 20; 
	private const int zSize = 16;

	public int[,] bluePrint = new int[zSize,xSize]			// This array controls the maze
	{	{ 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
		{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
		{ 1,0,1,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1 },
		{ 1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,1,0,1 },
		{ 1,0,1,0,0,0,0,1,1,0,1,1,0,1,1,0,0,0,0,1 },
		{ 1,0,0,1,1,1,0,1,0,0,0,1,0,1,1,0,1,1,0,1 },
		{ 1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,0,1,1,0,1 },
		{ 1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,1 },
		{ 1,0,0,1,1,1,0,1,1,1,1,1,0,1,1,1,1,1,0,1 },
		{ 1,1,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
		{ 1,1,0,1,0,0,0,1,1,1,1,0,1,1,1,1,0,1,1,1 },
		{ 1,0,0,1,0,1,1,0,0,0,1,0,1,1,1,1,0,0,0,1 },
		{ 1,0,1,1,0,0,0,0,1,0,1,0,0,0,0,0,0,1,0,1 },
		{ 1,0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,0,1,0,1 },
		{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
		{ 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
	};

	void Start () {

		GameObject[,] maze = new GameObject[zSize,xSize];
		for (int z=0 ; z<zSize ; z++){
			for (int x=0 ; x<xSize ; x++){
				if(bluePrint[z,x] == 1)
					maze[z,x] = Instantiate(Crate, new Vector3(x*2.0f-xSize+1, 0.0f, -z*2.0f+zSize-1), Quaternion.identity) as GameObject;
			}


		}
	}

	// Update is called once per frame
	void Update () 
	{

	}
}