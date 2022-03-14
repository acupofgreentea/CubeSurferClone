using UnityEngine;

public class TweenGameObject : MonoBehaviour
{
    [SerializeField] private float scaleX;
    [SerializeField] private float scaleY;
    [SerializeField] private float scaleZ;

    [SerializeField] private float tweenTime;

    [SerializeField] private bool loop;
    private void Start() 
    {
        Tween();
    }

    public void Tween()
    {
        Vector3 desiredScale = new Vector3(scaleX, scaleY, scaleZ);

        if(loop)
            gameObject.LeanScale(desiredScale, tweenTime).setLoopPingPong();
        else
        {
            gameObject.LeanScale(desiredScale, tweenTime).setOnComplete(() => gameObject.LeanScale(Vector3.one, tweenTime));
        }
    }
}
