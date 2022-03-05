using UnityEngine;

public class Collector : MonoBehaviour
{
    private Transform player;

    private int height = 0;

    private void Awake() 
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
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
        if(other.gameObject.CompareTag("Collectable") && !other.gameObject.GetComponent<Collectable>().IsCollected)
        {
            height++;
            other.gameObject.transform.parent = player;
            other.gameObject.GetComponent<Collectable>().SetHeight(height);
            other.gameObject.GetComponent<Collectable>().IsCollected = true;
        }
    }
}
