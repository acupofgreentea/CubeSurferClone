using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private ScoreManager score;

    private TweenGameObject tween;

    private void OnEnable() 
    {
        Gem.OnGemCollected += UpdateScoreText;
    }

    private void OnDisable() 
    {
        Gem.OnGemCollected -= UpdateScoreText;
    }

    private void Awake() 
    {
        tween = scoreText.gameObject.GetComponent<TweenGameObject>();
    }
    public void UpdateScoreText()
    {
        scoreText.text = score.Score.ToString();

        tween.Tween();
    }
}
