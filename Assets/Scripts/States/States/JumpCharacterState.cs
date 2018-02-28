using UnityEngine;
namespace States
{
	public class JumpCharacterState : ICharacterState
	{
		private Vector3 velocity;
		public JumpCharacterState(Vector3 initialVelocity)
		{
			velocity = initialVelocity;
		}

		public ICharacterState Jump()
		{
			return new DoubleJumpCharacterState(new Vector3(0, 2, 0));
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
