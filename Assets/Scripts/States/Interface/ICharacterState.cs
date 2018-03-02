using UnityEngine;

namespace States
{
	public interface ICharacterState
	{
		/// <summary>
		/// Something that can happen to a character - i.e. it can jump
		/// </summary>
		/// <returns>The new state resulted from the jump event</returns>
		ICharacterState Jump(float jumpForce);

		/// <summary>
		/// Needs a float to return value for usage in moving the character in the states that allow it.
		/// </summary>
		/// <returns></returns>
		ICharacterState Move(float xDirection);

		/// <summary>
		/// Ability to shoot in every state. Should get the spawn position.
		/// </summary>
		/// <param name="bulletPool"></param>
		/// <param name="position"></param>
		/// <returns></returns>
		ICharacterState Shoot(BulletObjectPool bulletPool, Vector3 position);

		/// <summary>
		/// Needs <paramref name="initialVelocity"/> to slow down the character when Crouching.
		/// </summary>
		/// <param name="initialVelocity"></param>
		/// <returns></returns>
		ICharacterState Crouch(float initialVelocity);

		/// <summary>
		/// Update the state's internal properties
		/// </summary>
		/// <param name="transform">The owner object's transformation</param>
		/// <returns>The new state resulted from the update</returns>
		ICharacterState UpdateState(Transform transform);
	}
}