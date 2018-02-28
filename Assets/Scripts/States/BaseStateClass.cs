using UnityEngine;
using States;

/// <summary>
/// Class containing default values for the interface-required functions.
/// </summary>
public abstract class BaseStateClass : MonoBehaviour, ICharacterState
{

	public virtual ICharacterState Jump()
	{
		return this;
	}

	public virtual ICharacterState Move(float xDirection)
	{
		return this;
	}

	public virtual ICharacterState UpdateState(Transform transform)
	{
		return this;
	}

	public virtual void Shoot()
	{
		//TODO: Add default behaviour for spawning a bullet.
	}
}
