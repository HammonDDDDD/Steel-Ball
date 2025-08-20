using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Premium : MonoBehaviour
{
    public TMP_Text gems2;

    public static bool isActive = false;
    private void Update()
    {
        gems2.text = Settings.Gems.ToString();
    }

    [SerializeField] InputField inputField;
    [SerializeField] Text resultText; 
    public void ButtonPress()
    {
        Application.OpenURL("https://t.me/+dF4_sZ13vsY0Mjgy");
    }

    public void InputCheck()
    {
        string input = inputField.text;
        if (input == "abobagaming")
        {
            resultText.text = "Ты нафига это купил?";
            resultText.color = Color.green;
            Settings.Gems += 20000;
            Premium.isActive = true;
  
        }
        else
        {
            resultText.text = "Incorrect code";
            resultText.color = Color.red;
        }
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene(3);
    }
}
