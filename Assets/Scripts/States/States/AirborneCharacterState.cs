using UnityEngine;
namespace States
{
	public class AirborneCharacterState : BaseStateClass
	{
		private Vector3 velocity;
		private int doubleJumps = 1;

		//Constructor
		public AirborneCharacterState(Vector3 initialVelocity)
		{
			velocity = initialVelocity;
		}

		/// <summary>
		/// Additional jumps after the initial jump (which is triggered via the GroundedState), ie. when you already are in THIS state.
		/// </summary>
		/// <returns></returns>
		public override ICharacterState Jump(float jumpForce)
		{
			if (doubleJumps > 0)
			{
				velocity = new Vector3(0, jumpForce, 0);
				doubleJumps--;
			}

			return this;
		}

		public override ICharacterState UpdateState(Transform transform)
		{
			transform.position += velocity * Time.deltaTime;
			velocity -= GameProperties.Gravity * Time.deltaTime;

			if (transform.position.y <= 0)
				return new GroundedCharacterState();

			return this;
		}
	}
}
