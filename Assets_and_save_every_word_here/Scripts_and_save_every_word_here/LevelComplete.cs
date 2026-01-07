using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        if (Input.GetKey(KeyCode.R))
        {
            FindAnyObjectByType<GameManager>().EndGame(0f);
        }
        else
        {
            Settings.Gems += PlayerCollision.LocalGems;
            Menu.RunGems += PlayerCollision.LocalGems;
            Menu.ALLGems += GameObject.FindGameObjectsWithTag("Gem").Length + PlayerCollision.LocalGems;
            PlayerCollision.LocalGems = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
