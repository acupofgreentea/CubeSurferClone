using UnityEngine;

[CreateAssetMenu(menuName ="Score")]
public class ScoreManager : ScriptableObject
{
    [SerializeField] private bool resetScore;
    
    public int Score {get; set;}

    private void OnEnable() 
    {
        if(resetScore)
            Score = 0;
    }

    public void UpdateScore(int scoreToAdd)
    {
        Score += scoreToAdd;
    }
}
