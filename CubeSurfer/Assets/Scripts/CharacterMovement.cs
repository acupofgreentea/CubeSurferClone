using UnityEngine;

public abstract class CharacterMovement : MonoBehaviour
{
    [SerializeField] protected float moveSpeed;

    protected IMovementInputGetter movementInputGetter;

    protected Rigidbody rb;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();

        movementInputGetter = GetComponent<IMovementInputGetter>();
    }

    private void FixedUpdate() 
    {
        Movement();
    }

    protected abstract void Movement();
}
