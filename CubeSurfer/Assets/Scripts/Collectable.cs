using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private AudioEvent obstacleAudio;

    [SerializeField] private ScoreManager score;

    private int index;

    public bool IsCollected {get; set;} = false;

    private Collector collector;

    private AudioSource source;

    private void Awake() 
    {
        collector = FindObjectOfType<Collector>();

        source = GetComponent<AudioSource>();
    }

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

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            obstacleAudio.PlayAudio(source, 0);

            score.UpdateScore(-1);

            collector.DecreaseHeight();
            transform.parent = null;

            GetComponent<BoxCollider>().enabled = false;

            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
