using UnityEngine;
using System.Collections;

namespace AssemblyCSharp
{
	public class Game : MonoBehaviour {
	
		// Use this for initialization
		void Start () {
			Debug.Log("Game");
			new Grid(5);
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}
