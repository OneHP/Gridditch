using System;
using System.Collections;
using UnityEngine;

namespace AssemblyCSharp
{
	public class Grid
	{
		
		private Hashtable grid;
		private int size;
		
		public Grid (int size)
		{
			this.size = size;
			this.grid = new Hashtable();
			
			for(int i = 0 ; i < size ; i++){
				for(int j = 0 ; j < size ; j++){
					this.grid[new Coordinate(i,j)] = GridItem.createEmpty();
				}
			}
			
			Debug.Log("Grid");
			Debug.Log(grid);
		}
	}
}

