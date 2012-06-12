using System;
using System.Collections;
using UnityEngine;

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
	
	public void print(){
		string output = "";
		for(int i = 0 ; i < size ; i++){
			for(int j = 0 ; j < size ; j++){
				output += "["+((GridItem)this.grid[new Coordinate(i,j)]).getType()+"]";
			}
			output += "\n";
		}
		Debug.Log (output);
	}
}
