using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private ScoreManager score;

    private void Update() 
    {
        scoreText.text = score.Score.ToString();
    }
}
