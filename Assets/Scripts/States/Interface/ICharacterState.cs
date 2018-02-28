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
        /// Update the state's internal properties
        /// </summary>
        /// <param name="transform">The owner object's transformation</param>
        /// <returns>The new state resulted from the update</returns>
        ICharacterState Update(Transform transform);
    }
}