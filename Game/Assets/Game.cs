using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
	public GameObject cube = null;
	
	// Use this for initialization
	void Start () {
		Debug.Log("Game");
		Grid grid = new Grid(5);
		grid.print ();
		
		Vector3 v = new Vector3(0, 0, 0);
		Quaternion q = Quaternion.identity;
		Instantiate(cube, v, q);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
