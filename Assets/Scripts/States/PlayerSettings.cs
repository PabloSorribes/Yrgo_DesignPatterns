using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSettings")]
public class PlayerSettings : ScriptableObject
{
	public float movementSpeed;
	public float jumpForce;
}
