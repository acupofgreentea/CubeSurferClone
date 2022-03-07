using UnityEngine;

public class TouchMovement : MonoBehaviour, IMovementInputGetter
{
    private Touch touch;

    private float multiplier = 0.1f;

    public float MovementInput()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            
            if(touch.phase != TouchPhase.Moved) return 0;

            return touch.deltaPosition.x * multiplier;

        }
        else 
            return 0;

    }
}
