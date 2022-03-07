using UnityEngine;

public class KeyboardMovement : MonoBehaviour, IMovementInputGetter
{
    public float MovementInput()
    {
        return Input.GetAxis("Horizontal");
    }
}
