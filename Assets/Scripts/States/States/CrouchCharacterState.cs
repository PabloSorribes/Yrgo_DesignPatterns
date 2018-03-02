using UnityEngine;

namespace States
{
	public class CrouchCharacterState : BaseStateClass
	{
		private Vector3 velocity;

		//Constructor
		public CrouchCharacterState (float initialVelocity)
		{
			velocity.x = initialVelocity;
			//TODO: Crouching here (scale character / change the sprite, etc)
		}

		// Take the inputed direction and save it to be used in "UpdateState()".
		public override ICharacterState Move(float xDirection)
		{
			velocity.x = xDirection / 2;
			return this;
		}

		public override ICharacterState UpdateState(Transform transform)
		{
			transform.position += velocity * Time.deltaTime;

			if (Input.GetKeyUp(KeyCode.S))
			{
				return new GroundedCharacterState();
			}

			return this;
		}
	}
}
