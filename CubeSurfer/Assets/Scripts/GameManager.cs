using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject startGameText;

    private bool gameStarted = false;

    private PlayerMovement playerMovement;

    private void Awake() 
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    private void Update() 
    {
        if(Input.anyKeyDown && !gameStarted)
        {
            gameStarted = true;

            startGameText.SetActive(false);

            playerMovement.enabled = true;
        }
    }
}
