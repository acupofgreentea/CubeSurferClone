using UnityEngine;

public class PlayerMovement : CharacterMovement
{
    protected override void Movement()
    {
        Vector3 movement = new Vector3(movementInputGetter.MovementInput(), 0, 1);

        //rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        transform.Translate(movement * moveSpeed *  Time.deltaTime, Space.Self);
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            RotatePlayer(-90);
        }
    }

    public void RotatePlayer(int rotate)
    {
        transform.Rotate(0, rotate, 0);
    }
}
