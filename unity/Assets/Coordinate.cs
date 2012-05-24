using System;

namespace AssemblyCSharp
{
	public class Coordinate
	{
		private int x;
		private int y;
		
		public Coordinate (int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		
		public int getX(){
			return this.x;
		}
		
		public int getY(){
			return this.y;
		}
		
		public override bool Equals(Object obj){
			return ((Coordinate)obj).x == this.x && ((Coordinate)obj).y == this.y;
		}	
	}
}

