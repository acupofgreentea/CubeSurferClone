using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : CharacterMovement
{
    public int Index {get; private set;} = 0;
    public void SetPosition()
    {
        Index++;
        transform.position = new Vector3(transform.position.x, Index, transform.position.z);
    }
}
