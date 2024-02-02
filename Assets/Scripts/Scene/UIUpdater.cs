using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{
    public Text scoreText;
    public PlayerData data;
    public Image healthImage;
    public void UpdateScoreText()
    {
        scoreText.text = "Score " + data.score;
    }
    public void UpdateHealthImage()
    {
        healthImage.fillAmount = data.health / data.maxHealth;
    }
}
