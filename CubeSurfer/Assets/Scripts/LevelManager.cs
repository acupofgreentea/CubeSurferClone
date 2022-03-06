using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerMovement>().enabled = false;

            StartCoroutine(NextLevelSequence(2f));
        }
    }

    private IEnumerator NextLevelSequence(float WaitForSeconds)
    {
        particle.Play();

        yield return new WaitForSeconds(WaitForSeconds);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
