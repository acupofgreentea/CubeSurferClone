using UnityEngine;

public class TweenGameObject : MonoBehaviour
{
    [SerializeField] private Vector3 scale;

    [SerializeField] private float tweenTime;

    [SerializeField] private bool loop;

    [SerializeField] private LeanTweenType leanTweenType;
    
    private void Start() 
    {
        if(!loop) return; 

        Tween();
    }

    public void Tween()
    {
        if(loop)
            gameObject.LeanScale(scale, tweenTime).setLoopPingPong();
        else
        {
            gameObject.LeanScale(scale, tweenTime).setEase(leanTweenType);
        }
    }
}
