using UnityEngine;

public class Gem : Collectable
{
    [SerializeField] private int bonusScore;

    [SerializeField] private bool randomizeScore;

    private int maxScore = 5;

    private void Awake() 
    {
        if(randomizeScore)
            bonusScore = Random.Range(1, maxScore);
        else
            bonusScore = maxScore;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Collector"))
        {
            if(IsCollected) return;
            
            audioEvent.PlayAudio(source, 0);

            gameObject.GetComponent<MeshRenderer>().enabled = false;

            score.UpdateScore(bonusScore);
        }
    }
}
