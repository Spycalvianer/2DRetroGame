using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public Text scoreText;
    public PlayerData playerDayta;
    public void UpdateScoreText()
    {
        scoreText.text = "Score " + playerDayta.score;
    }
}
