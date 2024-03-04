using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SceneStart : MonoBehaviour
{
    [SerializeField] Animator playerAnimator;
    bool jumpInpput;
    [SerializeField] GameObject gamemanager;
    [SerializeField] BuildingScript[] buildings;
    [SerializeField] AudioSource music;
    void Start()
    {
        Time.timeScale = 1;
        LevelStart();
        buildings = FindObjectsOfType<BuildingScript>();
        
        for (int i = 0; i < buildings.Length; i++)
        {
            buildings[i].buildingMovingSpeed = 0;
        }
    }
    private void Update()
    {
        GetInputToJump();
    }
    void GetInputToJump()
    {
        jumpInpput = Input.GetButtonDown("Jump");
        if (jumpInpput)
        {
            playerAnimator.SetTrigger("Jump");
        }
    }
    void LevelStart()
    {
        if(gamemanager != null) gamemanager.SetActive(false);
        if(music != null) music.Stop();
    }
    public void StartMovingGame()
    {
        gamemanager.SetActive(true);

        for (int i = 0; i < buildings.Length; i++)
        {
            buildings[i].buildingMovingSpeed = 4f;
        }
        music.Play();
    }
    public void DisableScript()
    {
        this.enabled = false;
    }
}
