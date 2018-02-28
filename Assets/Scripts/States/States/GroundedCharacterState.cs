using UnityEngine;
namespace States
{
	public class GroundedCharacterState : ICharacterState {

		public ICharacterState Jump()
		{
			return new JumpCharacterState(new Vector3(0,2,0));
		}

		public ICharacterState Update(Transform transform)
		{
			return this;
		}
	}
}
