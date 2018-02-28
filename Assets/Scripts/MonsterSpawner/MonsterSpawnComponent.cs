using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMonsterSpawner
{
	void SpawnSmallMonster();
}

public class DontSpawnAnything : IMonsterSpawner
{
	public void SpawnSmallMonster()
	{
		//do nothing
	}
}

public static class MonsterSpawner
{
	private static IMonsterSpawner _currentInstance;

	public static IMonsterSpawner CurrentInstance
	{
		get
		{
			if (_currentInstance == null)
				return new DontSpawnAnything();
			return _currentInstance;
		}
		internal set
		{
			_currentInstance = value;
		}
	}
}

public class MonsterSpawnComponent : MonoBehaviour, IMonsterSpawner {

	public GameObject monster;

	public void OnEnable()
	{
		MonsterSpawner.CurrentInstance = this;
	}

	private void OnDisable()
	{
		MonsterSpawner.CurrentInstance = null;
	}

	public void SpawnSmallMonster()
	{
		Instantiate(monster, transform);
	}
}
