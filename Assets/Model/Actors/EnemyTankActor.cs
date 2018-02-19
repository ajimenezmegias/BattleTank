using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class EnemyTankActor : BaseTankActor
{
	private const int ENEMY_TANK_HP = 1;
	private const int ENEMY_TANK_SPEED = 1;

	public EnemyTankActor() : base(ENEMY_TANK_HP, ENEMY_TANK_SPEED) { }

	public override void Update(float _timeSinceLastUpdate)
	{
		throw new NotImplementedException();
	}
}

