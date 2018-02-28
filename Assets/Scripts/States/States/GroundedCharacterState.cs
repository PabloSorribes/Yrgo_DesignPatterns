using UnityEngine;
namespace States
{
	public class GroundedCharacterState : BaseStateClass
	{

		private Vector3 velocity;
		private float speed = 10;

		public override ICharacterState Jump()
		{
			return new JumpCharacterState(new Vector3(0, 2, 0));
		}

		public override ICharacterState Move(float xDirection)
		{
			velocity.x = xDirection;
			return this;
		}

		public override ICharacterState UpdateState(Transform transform)
		{
			transform.position += velocity * Time.deltaTime * speed;
			return this;
		}
	}
}
