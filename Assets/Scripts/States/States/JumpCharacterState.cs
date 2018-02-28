using UnityEngine;
namespace States
{
	public class JumpCharacterState : BaseStateClass
	{
		private Vector3 velocity;
		public JumpCharacterState(Vector3 initialVelocity)
		{
			velocity = initialVelocity;
		}

		public override ICharacterState Jump()
		{
			return new DoubleJumpCharacterState(new Vector3(0, 2, 0));
		}

		public override ICharacterState Update(Transform transform)
		{
			transform.position += velocity * Time.deltaTime;
			velocity -= GameProperties.Gravity * Time.deltaTime;

			if (transform.position.y <= 0)
				return new GroundedCharacterState();

			return this;
		}
	}
}
