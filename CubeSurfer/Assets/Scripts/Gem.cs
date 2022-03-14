using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Gem : Collectable
{
    [SerializeField] private int bonusScore;

    [SerializeField] private bool randomizeScore;

    private int maxScore = 5;

    private MeshRenderer meshRenderer;
    
    public static Action OnGemCollected;

    protected override void Awake() 
    {
        base.Awake();
        
        if(randomizeScore)
            bonusScore = Random.Range(1, maxScore);
        else
            bonusScore = maxScore;

        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Collector"))
        {
            if(IsCollected) return;
            
            audioEvent.PlayAudio(source, 0);

            meshRenderer.enabled = false;

            score.UpdateScore(bonusScore);

            OnGemCollected();
        }
    }
}
