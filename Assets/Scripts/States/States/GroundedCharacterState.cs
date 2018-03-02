using UnityEngine;
namespace States
{
	public class GroundedCharacterState : BaseStateClass
	{
		private Vector3 velocity;

		/// <summary>
		/// Sets the new state to "Airborne", and executes a jump.
		/// </summary>
		/// <returns></returns>
		public override ICharacterState Jump(float jumpForce)
		{
			return new AirborneCharacterState(new Vector3(0, jumpForce, 0));
		}

		// Take the inputed direction and save it to be used in "UpdateState()".
		public override ICharacterState Move(float xDirection)
		{
			velocity.x = xDirection;
			return this;
		}

		public override ICharacterState Crouch(float initialVelocity)
		{
			return new CrouchCharacterState(initialVelocity);
		}

		public override ICharacterState UpdateState(Transform transform)
		{
			transform.position += velocity * Time.deltaTime;
			return this;
		}
	}
}
