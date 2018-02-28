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

	public virtual ICharacterState Update(Transform transform)
	{
		return this;
	}
}
