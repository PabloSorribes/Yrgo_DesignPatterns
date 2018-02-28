using UnityEngine;
using States;

/// <summary>
/// Component that allows for jumping using the state design pattern
/// </summary>
public class StateMachineJumpComponent : MonoBehaviour
{
    private ICharacterState state = new GroundedCharacterState();

    public void Update()
    {
        if (Input.GetButtonDown("Jump"))
            state = state.Jump();
        state = state.Update(transform);
    }
}