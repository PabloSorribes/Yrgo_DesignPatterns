using UnityEngine;

namespace States
{
	public interface ICharacterState
	{
		/// <summary>
		/// Something that can happen to a character - i.e. it can jump
		/// </summary>
		/// <returns>The new state resulted from the jump event</returns>
		ICharacterState Jump();

		/// <summary>
		/// Needs a float to return value for usage in moving the character in the states that allow it.
		/// </summary>
		/// <returns></returns>
		ICharacterState Move(float xDirection);

		/// <summary>
		/// Update the state's internal properties
		/// </summary>
		/// <param name="transform">The owner object's transformation</param>
		/// <returns>The new state resulted from the update</returns>
		ICharacterState UpdateState(Transform transform);
	}
}