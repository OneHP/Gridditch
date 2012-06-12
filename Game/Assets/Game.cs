using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
	public GameObject gridItemCube;
	
	// Use this for initialization
	void Start () {
		Debug.Log("Game");
		Grid grid = new Grid(this,5);
		grid.print ();
		
		grid.draw();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void drawCube(Vector3 position, Quaternion q){
		Instantiate(gridItemCube, position, q);
		Debug.Log("drawn cube");
	}
}
