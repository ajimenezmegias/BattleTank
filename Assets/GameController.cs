using System.Collections.Generic;

public class GameController
{
	private List<BaseActor> m_actors;
	private BaseActor[,] m_grid;
	public int GridWidth { get { return m_grid.GetLength(0); } }

	public void AddActor(BaseActor _actor)
	{
		_actor.OnActorMoved += OnActorMoved;
		m_actors.Add(_actor);
	}

	public void RemoveActor(BaseActor _actor)
	{
		_actor.OnActorMoved -= OnActorMoved;
		m_actors.Remove(_actor);
	}

	private void OnActorMoved(BaseActor _actor, Position _oldPos, Position _newPos)
	{
		m_grid[_oldPos.X, _oldPos.Y] = null;
		m_grid[_newPos.X, _newPos.Y] = _actor;
	}

	public BaseActor GetCell(int _x, int _y)
	{
		return m_grid[_x, _y];
	}
}
