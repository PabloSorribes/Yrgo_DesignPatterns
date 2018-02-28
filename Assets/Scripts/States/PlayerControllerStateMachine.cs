using UnityEngine;
using States;

/// <summary>
/// Component which takes the control-input for moving the character.
/// </summary>
public class PlayerControllerStateMachine : MonoBehaviour
{
	private ICharacterState state = new GroundedCharacterState();
	

	public void Update()
	{
		JumpInput();
		MoveInput();

		UpdateState();
	}

	private void JumpInput()
	{
		if (Input.GetButtonDown("Jump"))
			state = state.Jump();
	}

	private void MoveInput()
	{
		float inputX = Input.GetAxisRaw("Horizontal");
		state = state.Move(inputX);
	}

	/// <summary>
	/// Has to be at the end of an Update()-loop to update the state everywhere correctly.
	/// </summary>
	private void UpdateState()
	{
		state = state.UpdateState(transform);
	}
}