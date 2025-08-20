using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class King : MonoBehaviour
{
   
    public AudioSource AudioSource;
    public AudioClip voice1;
    public AudioClip voice2;
    public AudioClip voice3;
    int prescnt = 0;
    
    public TMP_Text cnt;
    public void GoToMenu()
    {
        SceneManager.LoadScene(3);
    }

    void Update()
    {
        cnt.text = Settings.Gems.ToString();
    }
    public void PremiumButton()
    {
        prescnt++;
        if (Settings.Gems >= 1000)
        {
            Settings.Gems -= 1000;
            if (prescnt % 3 == 0)
            {
                AudioSource.clip = voice1;
                AudioSource.Play();
            }
            else if (prescnt % 3 == 1)
            {
                AudioSource.clip = voice2;
                AudioSource.Play();
            }
            else
            {
                AudioSource.clip = voice3;
                AudioSource.Play();
            }
        }

    }
}
