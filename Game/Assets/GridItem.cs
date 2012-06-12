using System;

public class GridItem
{
	private static int DEFAULT_HEALTH = 2;
	
	private int value;
	private GridItemType type;
	private int health;
	
	private GridItem (int value, GridItemType type, int health)
	{
		this.value = value;
		this.type = type;
		this.health = health;
	}
	
	public static GridItem createEmpty(){
		return new GridItem(0,GridItemType.EMPTY,0);
	}
	
	public static GridItem createActive(int value){
		return new GridItem(value,GridItemType.ACTIVE,0);
	}
	
	public static GridItem createInactive(){
		return new GridItem(0,GridItemType.INACTIVE,DEFAULT_HEALTH);
	}
	
	public GridItemType getType(){
		return type;
	}
}

public enum GridItemType{
	
	ACTIVE,
	
	INACTIVE,
	
	EMPTY
}
