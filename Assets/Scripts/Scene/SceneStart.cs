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
    [SerializeField] ObjectMoveScript balconyMoving;
    void Start()
    {
        Time.timeScale = 1;
        if(balconyMoving != null) balconyMoving.enabled = false;
        gamemanager = GameObject.Find("GameManager");
        if(gamemanager != null) gamemanager.SetActive(false);
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
            gamemanager.SetActive(true);
        }
    }
    void LevelStart()
    {
        if(music != null) music.Stop();
    }
    public void StartMovingGame()
    {
        balconyMoving.enabled=true;

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
