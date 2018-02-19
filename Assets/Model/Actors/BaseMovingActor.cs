using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMovingActor : BaseActor
{
	/// <summary>
	/// Speed as "cooldown" to change tile
	/// </summary>
	public readonly float Speed;

	public BaseMovingActor(int _totalHP, float _speed) : base(_totalHP)
	{
		Speed = _speed;
	}
}
