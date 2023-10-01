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
            ChangeScene(sceneName);
        }
    }
    public void ChangeScene(string nameOfScene)
    {
        SceneManager.LoadScene(nameOfScene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
