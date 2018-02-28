using UnityEngine;
namespace States
{
	public class DoubleJumpCharacterState : ICharacterState
	{
		private Vector3 velocity;
		public DoubleJumpCharacterState(Vector3 initialVelocity)
		{
			velocity = initialVelocity;
		}

		public ICharacterState Jump()
		{
			return this;
		}

		public ICharacterState Update(Transform transform)
		{
			transform.position += velocity * Time.deltaTime;
			velocity -= GameProperties.Gravity * Time.deltaTime;

			if (transform.position.y <= 0)
				return new GroundedCharacterState();

			return this;
		}
	}
}
