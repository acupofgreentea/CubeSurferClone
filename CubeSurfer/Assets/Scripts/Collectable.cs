using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] protected AudioEvent audioEvent;

    [SerializeField] protected ScoreManager score;

    public bool IsCollected {get; set;} = false;

    protected Collector collector;

    protected AudioSource source;

    protected virtual void Awake() 
    {
        collector = FindObjectOfType<Collector>();

        source = GetComponent<AudioSource>();
    }
}
