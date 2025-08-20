using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Settings : MonoBehaviour
{
    public GameObject DifPW;
    public GameObject VolumePW;
    public GameObject LangPW;
    public GameObject SpecialPW;
    public GameObject ArtuhCB;
    public GameObject SanyaCB;
    public static bool Sanya = false;
    public static bool AM = false;
    public static bool RGB = false;
    public static bool casuals = true;
    public static float volumemod = 1f;
    public static int Gems = 0;
    public TMP_Text CNT;
    public static bool Started = false;

    public void Start()
    {
        if (Started == false)
        {
            Started = true;
            SceneManager.LoadScene(3);
        }
    }
    public void Update()
    {
        CNT.text = Gems.ToString();

    }
    public void GoToMenu()
    {
        SceneManager.LoadScene(3);
    }

    public void AMON()
    {
        if (Sanya)
        {
            SanyaCB.GetComponentInChildren<Toggle>().isOn = false;
            Sanya = false;

        }
        AM = !AM;
    }
    public void LangChange()
    {
        if (AM)
        {
            ArtuhCB.GetComponentInChildren<Toggle>().isOn = false;
            AM = false;

        }
        Sanya = !Sanya;
    }
    public void RGBON()
    {
        RGB = !RGB;
    }  
    public void DifChange()
    {
        casuals = !casuals;
    }


    public void VolumeChange()
    {
        volumemod = FindFirstObjectByType<Slider>().value;
    }

    public void UnlockVolume()
    {
        if (Settings.Gems >= 500)
        {
            Settings.Gems -= 500;
            Destroy(VolumePW);
        }
    }
    public void UnlockDif()
    {
        if (Settings.Gems >= 2000)
        {
            Settings.Gems -= 2000;
            Destroy(DifPW);
        }
    }
    public void UnlockSpecial()
    {
        if (Settings.Gems >= 10000)
        {
            Settings.Gems -= 10000;
            Destroy(SpecialPW);
        }
    }
    public void UnlockLanguage()
    {
        if (Settings.Gems >= 5000)
        {
            Settings.Gems -= 5000;
            Destroy(LangPW);
        }
    }

}
