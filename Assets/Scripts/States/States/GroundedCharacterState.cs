﻿using UnityEngine;
namespace States
{
	public class GroundedCharacterState : BaseStateClass
	{

		private Vector3 velocity;
		private float speed = 10;

		/// <summary>
		/// Sets the new state to "Jump".
		/// </summary>
		/// <returns></returns>
		public override ICharacterState Jump()
		{
			return new JumpCharacterState(new Vector3(0, 2, 0));
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
			transform.position += velocity * Time.deltaTime * speed;
			return this;
		}
	}
}
