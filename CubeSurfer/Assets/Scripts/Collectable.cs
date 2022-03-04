using UnityEngine;

public class Collectable : MonoBehaviour
{
    private int index;

    public bool IsCollected {get; set;} = false;

    private void Update() 
    {
        if(IsCollected)
        {
            transform.localPosition = new Vector3(0, -index, 0);
        }
    }
    public void SetHeight(int index)
    {
        this.index = index;
    }
}
