using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] private AudioEvent collectSound;

    [SerializeField] private ScoreManager score;

    private Transform player;

    private AudioSource source;

    private int height = 0;


    private void Awake() 
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        source = GetComponent<AudioSource>();
    }

    private void Update() 
    {
        player.position = new Vector3(player.position.x, height + 1, player.position.z);
        transform.localPosition = new Vector3(0, -height, 0);
    }

    public void DecreaseHeight()
    {
        height--;
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Collectable") && !other.gameObject.GetComponent<Cube>().IsCollected)
        {
            collectSound.PlayAudio(source, 0);
            height++;
            other.gameObject.transform.parent = player;
            other.gameObject.GetComponent<Cube>().SetHeight(height);
            other.gameObject.GetComponent<Cube>().IsCollected = true;
        }
    }
}
