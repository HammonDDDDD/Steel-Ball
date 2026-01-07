using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static int RunGems = 0;
    public static int ALLGems = 0;
    
    public void StartGame()
    {
        Menu.RunGems = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GotoSettings()
    {
        SceneManager.LoadScene(0);

    }
    public void BuyPremium()
    {
        SceneManager.LoadScene(2);
    }
    public void ShowTitles()
    {
        SceneManager.LoadScene(1);
    }
}
