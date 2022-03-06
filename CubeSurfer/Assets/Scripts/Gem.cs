using UnityEngine;

public class Gem : Collectable
{
    [SerializeField] private int bonusScore = 5;
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
