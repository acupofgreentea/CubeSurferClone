using UnityEngine;

public class Collectable : MonoBehaviour
{
    private int index;

    public bool IsCollected {get; set;} = false;

    private Collector collector;

    private void Awake() 
    {
        collector = FindObjectOfType<Collector>();
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
            transform.parent = null;
            collector.DecreaseHeight();

            GetComponent<BoxCollider>().enabled = false;

            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
