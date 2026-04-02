using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int maxLives = 3;
    public int currentLives;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentLives = maxLives;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Missile"))
        {
            currentLives--;
            Destroy(other.gameObject);
        }
    }

    void GameOver()
    {
        gameObject.SetActive(false);
        Invoke("RestarGame", 3.0f);
    }

    void RestarGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
