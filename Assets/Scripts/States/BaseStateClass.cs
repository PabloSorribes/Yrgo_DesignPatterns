using UnityEngine;

namespace States
{
	/// <summary>
	/// Class containing default values for the interface-required functions.
	/// </summary>
	public abstract class BaseStateClass : ICharacterState
	{
		//"Return this" means that you return which state you are in, ie. which class is being used.
		public virtual ICharacterState Jump(float jumpForce)
		{
			return this;
		}

		public virtual ICharacterState Move(float xDirection)
		{
			return this;
		}

		/// <summary>
		/// Allow Shooting in every state.
		/// </summary>
		/// <param name="bulletPool"></param>
		/// <param name="position"></param>
		/// <returns></returns>
		public virtual ICharacterState Shoot(BulletObjectPool bulletPool, Vector3 position)
		{
			var newBullet = bulletPool.CreateBullet();
			newBullet.transform.position = position;

			//TODO: Rotate the bullet depending on which direction you are walking in here, instead of in Bullet.cs
			if (Input.GetAxisRaw("Horizontal") < 0)
			{
				//Code
			}
			return this;
		}

		public virtual ICharacterState Crouch(float initialVelocity)
		{
			return this;
		}

		public virtual ICharacterState UpdateState(Transform transform)
		{
			return this;
		}
	}
}

