using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    protected Rigidbody rb;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() 
    {
        Movement();
    }

    protected virtual void Movement()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
