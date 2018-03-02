using UnityEngine;
using States;

/// <summary>
/// Component which takes the control-input for moving the character.
/// </summary>
public class PlayerControllerStateMachine : MonoBehaviour
{
	//This automatically checks if you are airborne or not.
	private ICharacterState state = new AirborneCharacterState(Vector3.zero);
	private BulletObjectPool bulletPool;
	public PlayerSettings playerSettings;

	private void Start()
	{
		bulletPool = FindObjectOfType<BulletObjectPool>();
	}

	public void Update()
	{
		JumpInput();
		MoveInput();
		ShootInput();
		CrouchInput();
		UpdateState();
	}

	private void JumpInput()
	{
		if (Input.GetButtonDown("Jump"))
		{
			state = state.Jump(playerSettings.jumpForce);
		}
	}

	private void MoveInput()
	{
		float inputX = Input.GetAxisRaw("Horizontal");
		state = state.Move(inputX * playerSettings.movementSpeed);
	}

	private void ShootInput()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			state = state.Shoot(bulletPool, transform.position);
		}
	}

	private void CrouchInput()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			float inputX = Input.GetAxisRaw("Horizontal");
			state = state.Crouch(inputX);
		}
	}

	/// <summary>
	/// Has to be at the end of an Update()-loop to update the state everywhere correctly.
	/// </summary>
	private void UpdateState()
	{
		state = state.UpdateState(transform);
		print(state);
	}
}