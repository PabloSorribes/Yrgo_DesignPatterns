using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MonsterSpawner.CurrentInstance.SpawnSmallMonster();
	}

}
