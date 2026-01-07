using UnityEngine; using UnityEngine.SceneManagement;

public class Sale : MonoBehaviour
{
    public GameObject Paywall;

    public void OpenPaywall()
    {
        Destroy(Paywall);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(2);
    }
}
