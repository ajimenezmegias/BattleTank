using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallActor : BaseActor
{
	private const int WALL_HP = 3;

	public WallActor() : base(WALL_HP, 0) { }
	public override void Update(float _timeSinceLastUpdate) { }
}
