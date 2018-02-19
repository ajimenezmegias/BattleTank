using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletActor : BaseMovingActor
{
	private const int ENEMY_BULLET_HP = 1;
	private const int ENEMY_BULLET_SPEED = 1;

	private new readonly Direction Direction;

	public BulletActor(Direction _dir) : base(ENEMY_BULLET_HP, ENEMY_BULLET_SPEED)
	{
		Direction = _dir;
	}

	public override void Update(float _timeSinceLastUpdate)
	{
		throw new NotImplementedException();
	}
}
