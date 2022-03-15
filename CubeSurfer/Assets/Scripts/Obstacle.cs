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

            Time.timeScale = 0;

            other.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}
