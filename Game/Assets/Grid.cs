using System;
using System.Collections;
using UnityEngine;

public class Grid
{
	
	private Game parent;
	private Hashtable grid;
	private int size;
	
	public Grid (Game parent, int size)
	{
		this.parent = parent;
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
	
	public void draw(){
		Quaternion noRotation = new Quaternion();
		for(int i = 0 ; i < size ; i++){
			for(int j = 0 ; j < size ; j++){
				parent.drawCube(new Vector3(i*1.1f,j*1.1f,0),noRotation);
			}
		}
	}
}
