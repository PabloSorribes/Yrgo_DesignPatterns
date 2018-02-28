using UnityEngine;

/// <summary>
/// Component that allows for jumping without using the state design pattern
/// </summary>
public class JumpComponent : MonoBehaviour
{
	private Vector3 velocity = Vector3.zero;
    private bool onGround = true;
    private bool jumping = false;
    private bool doubleJumping = false;

    public void Update()
    {
        if (onGround)
        {
            // Allow jumping if we are standing on the ground, but not already jumping
            if (Input.GetButtonDown("Jump") && !jumping)
            {
                onGround = false;
                jumping = true;
                velocity = new Vector3(0, 2, 0);
            }
        }
        else
        {
            // If we are jumping then allow a double jump. But only once
            if (Input.GetButtonDown("Jump") && jumping && !doubleJumping)
            {
                doubleJumping = true;
                velocity = new Vector3(0, 2, 0);
            }
        }

        if (jumping)
        {
            // Move the character up and down while we are jumping
            velocity -= GameProperties.Gravity * Time.deltaTime;
            transform.position += velocity * Time.deltaTime;

            // If we hit the ground then stop jumping
            if (transform.position.y <= 0)
            {
                jumping = false;
                onGround = true;
                doubleJumping = false;
                velocity = Vector3.zero;
            }
        }
    }
}