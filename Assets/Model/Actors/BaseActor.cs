using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseActor
{
	public delegate void ActorMoved(BaseActor _actor, Position _oldPos, Position _newPos);
	public event ActorMoved OnActorMoved;

	public readonly int TotalHP;

	public int CurrentHP;
	public Position Position;
	public Direction Direction;
	private int v;

	public BaseActor(int _totalHP)
	{
		TotalHP = _totalHP;
	}

	public BaseActor(int _totalHP, int v) : this(_totalHP)
	{
		this.v = v;
	}

	public abstract void Update(float _timeSinceLastUpdate);

	protected void NotifyOnActorMoved(Position _oldPos, Position _newPos)
	{
		if (OnActorMoved != null)
		{
			OnActorMoved(this, _oldPos, _newPos);
		}
	}
}
