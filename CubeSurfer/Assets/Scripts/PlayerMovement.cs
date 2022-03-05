using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : CharacterMovement
{
    protected override void Movement()
    {
        float moveX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = moveSpeed * Time.deltaTime;

        transform.Translate(moveX, 0, moveZ);
    }
}
