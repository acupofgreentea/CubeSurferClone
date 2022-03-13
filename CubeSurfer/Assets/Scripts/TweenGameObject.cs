using UnityEngine;

public class TweenGameObject : MonoBehaviour
{
    [SerializeField] private float scaleX;
    [SerializeField] private float scaleY;
    [SerializeField] private float scaleZ;

    [SerializeField] private float tweenTime;
    private void Start() 
    {
        TweenText();
    }

    public void TweenText()
    {
        Vector3 desiredScale = new Vector3(scaleX, scaleY, scaleZ);
        gameObject.LeanScale(desiredScale, tweenTime).setLoopPingPong();
    }
}
