using UnityEngine;

public class PlayerMovement : CharacterMovement
{
    protected override void Movement()
    {
        float moveX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = moveSpeed * Time.deltaTime;

        Vector3 movement = new Vector3(moveX, 0, moveZ).normalized;

        rb.MovePosition(rb.position +  movement);
    }
}
