using UnityEngine;

public class ScoreMultiplier : MonoBehaviour
{
    [SerializeField] private int multiplier;

    [SerializeField] private ScoreManager score;

    private BoxCollider col;

    private void Awake() 
    {
        col = GetComponent<BoxCollider>();
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            score.Score *= multiplier;
            Debug.Log(score.Score);

            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Collector"))
        {
            other.gameObject.GetComponent<Collector>().DecreaseHeight();
            col.enabled = false;
        }
    }
}
