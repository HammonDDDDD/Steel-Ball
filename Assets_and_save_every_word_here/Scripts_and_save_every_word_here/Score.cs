using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI scoreText;
    void Update()
    {
        scoreText.text = (PlayerCollision.LifeCounter).ToString("0");
    }
}
