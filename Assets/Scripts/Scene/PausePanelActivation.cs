using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanelActivation : MonoBehaviour
{
    public GameObject pausePanel;
    void Start()
    {
        pausePanel.SetActive(false);
    }
    private void Update()
    {
        TimeScaleController();
    }
    public void PausePanel()
    {
        pausePanel.SetActive(!pausePanel.activeSelf);
    }
    void TimeScaleController()
    {
        if (pausePanel.activeSelf == true) Time.timeScale = 0;
        else Time.timeScale = 1;
    }
}
