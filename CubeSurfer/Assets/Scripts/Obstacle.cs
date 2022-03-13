using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private BoxCollider boxCollider;

    private void Awake() 
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            boxCollider.enabled = false;

            //stopgame

            other.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}
