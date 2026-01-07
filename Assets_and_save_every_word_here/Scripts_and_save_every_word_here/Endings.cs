using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Endings : MonoBehaviour
{
    public TMP_Text LocalGemsCnt;
    


    void Start()
    {
        if (Govno._audioSource != null)
        {
            Destroy(Govno._audioSource);

        }
        LocalGemsCnt.text = Menu.RunGems.ToString();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(3);
    }
    public void BomjEnding()
    {
        if (Menu.RunGems >= 150)
            SceneManager.LoadScene(10);
    }
    public void KingEnding()
    {
        if ((Menu.RunGems >= 350) && Premium.isActive == true)
            SceneManager.LoadScene(11);
    }



}
