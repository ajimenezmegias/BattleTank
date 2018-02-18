using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseActor
{
	public int HP;

	public Position Position;
	public Direction Direction;

	/// <summary>
	/// Speed as "cooldown" to change tile
	/// </summary>
	public float Speed;
}

public class GameController
{
    private List<BaseActor> Actors;
    private  BaseActor[,] Grid;
}

public class GameBoard
{
    
}
