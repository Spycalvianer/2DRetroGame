using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangingScript : MonoBehaviour
{
    public string sceneName;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            LoadSpecificScene(sceneName);
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadSpecificScene(string nameOfScene)
    {
        SceneManager.LoadScene(nameOfScene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PanelActivation(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
}