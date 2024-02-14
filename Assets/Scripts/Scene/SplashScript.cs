using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScript : MonoBehaviour
{
    [SerializeField] GameObject winPanel;
    [SerializeField] GameManager gameManager;
    Canvas sceneCanvas;

    public void ActivateWinPanel()
    {
        sceneCanvas = GameObject.Find("---UICanvas---").GetComponent<Canvas>();
        Instantiate(winPanel, sceneCanvas.transform);
        Time.timeScale = 0;
    }
}
