using UnityEngine;

public class Cube : Collectable
{
    private int index;
    
    private void Update() 
    {
        if(!IsCollected) return;

        transform.localPosition = new Vector3(0, -index, 0);
    }

    public void SetHeight(int index)
    {
        this.index = index;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            audioEvent.PlayAudio(source, 0);

            score.UpdateScore(-1);

            collector.DecreaseHeight();

            transform.parent = null;

            other.gameObject.GetComponent<BoxCollider>().enabled = false;

            Destroy(gameObject, 1f);
        }
    }
}
