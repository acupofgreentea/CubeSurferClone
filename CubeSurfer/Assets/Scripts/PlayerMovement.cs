using UnityEngine;

public class PlayerMovement : CharacterMovement
{
    protected override void Movement()
    {
        Debug.Log(movementInputGetter.MovementInput());
        Vector3 movement = new Vector3(movementInputGetter.MovementInput(), 0, 1);

        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}
