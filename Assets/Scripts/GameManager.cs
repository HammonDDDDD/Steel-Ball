using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public TMP_Text gems;
    public GameObject CompleteLevelUI;
    private bool ArtuhMode = Settings.AM;
    private bool SanyaMode = Settings.RGB;
    public Material SanyaTexture;
    public GameObject player;
    public Material ArtuhTexture;
    public Material BaseMaterial;
    public TMP_Text LCGems;
    public GameObject NoWay;

    private void Start()
    {
        if (ArtuhMode == true)
        {
            player.GetComponent<Renderer>().material = ArtuhTexture;
        }
        else
            player.GetComponent<Renderer>().material = BaseMaterial;
        if (SanyaMode == true)
        {
            player.GetComponent<Renderer>().material = SanyaTexture;
        }
        if (Settings.casuals == false)
        {
            NoWay.SetActive(true);
        }
    }

    public void Update()
    {
        gems.text = PlayerCollision.LocalGems.ToString();
        if (Input.GetKey(KeyCode.R))
        {
            EndGame(0f);
        }
    }
    public void CompleteLevel()
    {
        int totalgems = GameObject.FindGameObjectsWithTag("Gem").Length+PlayerCollision.LocalGems;
        int localgems = PlayerCollision.LocalGems;
        LCGems.text = $"Gems collected: {localgems} / {totalgems}";
        CompleteLevelUI.SetActive(true);
    }

    public void EndGame(float restartdelay)
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            PlayerCollision.LocalGems = 0; 

            Invoke("Restart", restartdelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerCollision.LocalGems = 0;
        PlayerCollision.LifeCounter = 2;
        BossFight.BossHP = 3;
    }
    


}
